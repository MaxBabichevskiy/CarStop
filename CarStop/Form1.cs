using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStop
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Data Source=KOMPUTER\\;Initial Catalog=BrakingDistanceCalculator;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double length = double.Parse(lengthTextBox.Text);
            double width = double.Parse(widthTextBox.Text);
            double height = double.Parse(heightTextBox.Text);
            int passengers = int.Parse(passengersTextBox.Text);

            string weather = weatherComboBox.SelectedItem.ToString();
            string surface = surfaceComboBox.SelectedItem.ToString();
            string tireType = tireTypeComboBox.SelectedItem.ToString();

            double friction = GetFrictionCoefficient(weather, surface, tireType);

            double weight = GetWeight(length, width, height, passengers);
            double speed = GetSpeed();

            if (!double.TryParse(lengthTextBox.Text, out length))
            {
                MessageBox.Show("Некорректное значение длины автомобиля");
                return;
            }
            if (!double.TryParse(widthTextBox.Text, out width))
            {
                MessageBox.Show("Некорректное значение ширины автомобиля");
                return;
            }
            if (!double.TryParse(heightTextBox.Text, out height))
            {
                MessageBox.Show("Некорректное значение высоты автомобиля");
                return;
            }
            if (!int.TryParse(passengersTextBox.Text, out passengers))
            {
                MessageBox.Show("Некорректное значение количества пассажиров");
                return;
            }

            double stoppingDistance = (speed * speed) / (2 * friction * 9.81) + (speed * 0.1);
            double stoppingTime = speed / (friction * 9.81) + 1;

            brakingDistanceLabel.Text = $"Тормозной путь: {stoppingDistance:F2} м";
            brakingTimeLabel.Text = $"Время остановки: {stoppingTime:F2} с";

            SaveResultToDatabase(stoppingDistance, stoppingTime);
        }

        private double GetFrictionCoefficient(string weather, string surface, string tireType)
        {
            double weather_code = 0, surface_code = 0, tireType_code = 0;

            switch (weather)
            {
                case "Sun": weather_code = 0.6; break;
                case "Rain": weather_code = 0.40; break;
                default:
                    break;
            }

            switch (surface)
            {
                case "Asphalt": surface_code = 0.35; break;
                case "Off-road": surface_code = 0.3; break;
                default:
                    break;
            }

            switch (tireType)
            {
                case "Sport": tireType_code = 0.3; break;
                case "Stock": tireType_code = 0.25; break;
                case "Drag": tireType_code = 0.25; break;
                default:
                    break;
            }

            double friction = weather_code + surface_code + tireType_code;

            return friction;
        }

        private double GetWeight(double length, double width, double height, int passengers)
        {
            double weight = length * width * height * 1.5 + 70 * passengers;
            return weight;
        }

        private double GetSpeed()
        {
            double speed = double.Parse(speedTextBox.Text);
            return speed;
        }

        private void SaveResultToDatabase(double stoppingDistance, double stoppingTime)
        {
            try
            {
                string insertCommand = "INSERT INTO BrakingDistances (StoppingDistance, StoppingTime) " +
                    "VALUES (@StoppingDistance, @StoppingTime)";
                SqlCommand command = new SqlCommand(insertCommand, connection);

                command.Parameters.AddWithValue("@StoppingDistance", stoppingDistance);
                command.Parameters.AddWithValue("@StoppingTime", stoppingTime);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении результатов в базу данных: " + ex.Message);
            }
        }       

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
