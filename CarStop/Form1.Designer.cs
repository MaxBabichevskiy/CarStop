namespace CarStop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.passengersTextBox = new System.Windows.Forms.TextBox();
            this.weatherComboBox = new System.Windows.Forms.ComboBox();
            this.surfaceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tireTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.brakingDistanceLabel = new System.Windows.Forms.Label();
            this.brakingTimeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(185, 151);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Посчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(103, 6);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 3;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(103, 32);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 4;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(103, 64);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 5;
            // 
            // passengersTextBox
            // 
            this.passengersTextBox.Location = new System.Drawing.Point(103, 125);
            this.passengersTextBox.Name = "passengersTextBox";
            this.passengersTextBox.Size = new System.Drawing.Size(100, 20);
            this.passengersTextBox.TabIndex = 6;
            // 
            // weatherComboBox
            // 
            this.weatherComboBox.FormattingEnabled = true;
            this.weatherComboBox.Items.AddRange(new object[] {
            "Sun",
            "Rain"});
            this.weatherComboBox.Location = new System.Drawing.Point(286, 9);
            this.weatherComboBox.Name = "weatherComboBox";
            this.weatherComboBox.Size = new System.Drawing.Size(121, 21);
            this.weatherComboBox.TabIndex = 7;
            // 
            // surfaceComboBox
            // 
            this.surfaceComboBox.FormattingEnabled = true;
            this.surfaceComboBox.Items.AddRange(new object[] {
            "Asphalt",
            "Off-road"});
            this.surfaceComboBox.Location = new System.Drawing.Point(286, 39);
            this.surfaceComboBox.Name = "surfaceComboBox";
            this.surfaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.surfaceComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "К-во пассажиров";
            // 
            // tireTypeComboBox
            // 
            this.tireTypeComboBox.FormattingEnabled = true;
            this.tireTypeComboBox.Items.AddRange(new object[] {
            "Sport",
            "Stock",
            "Drag"});
            this.tireTypeComboBox.Location = new System.Drawing.Point(286, 66);
            this.tireTypeComboBox.Name = "tireTypeComboBox";
            this.tireTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.tireTypeComboBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Погода";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Поверхность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Тип шин";
            // 
            // brakingDistanceLabel
            // 
            this.brakingDistanceLabel.AutoSize = true;
            this.brakingDistanceLabel.Location = new System.Drawing.Point(211, 128);
            this.brakingDistanceLabel.Name = "brakingDistanceLabel";
            this.brakingDistanceLabel.Size = new System.Drawing.Size(49, 13);
            this.brakingDistanceLabel.TabIndex = 18;
            this.brakingDistanceLabel.Text = "Тип шин";
            // 
            // brakingTimeLabel
            // 
            this.brakingTimeLabel.AutoSize = true;
            this.brakingTimeLabel.Location = new System.Drawing.Point(211, 103);
            this.brakingTimeLabel.Name = "brakingTimeLabel";
            this.brakingTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.brakingTimeLabel.TabIndex = 19;
            this.brakingTimeLabel.Text = "Тип шин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Скорость";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(103, 96);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedTextBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 212);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.brakingTimeLabel);
            this.Controls.Add(this.brakingDistanceLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tireTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surfaceComboBox);
            this.Controls.Add(this.weatherComboBox);
            this.Controls.Add(this.passengersTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox passengersTextBox;
        private System.Windows.Forms.ComboBox weatherComboBox;
        private System.Windows.Forms.ComboBox surfaceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tireTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label brakingDistanceLabel;
        private System.Windows.Forms.Label brakingTimeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox speedTextBox;
    }
}

