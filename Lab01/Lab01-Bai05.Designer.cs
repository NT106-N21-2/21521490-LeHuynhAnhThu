namespace Lab01
{
    partial class Lab01_Bai05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox_vehicle = new ComboBox();
            comboBox_fuel = new ComboBox();
            textBox_distance = new TextBox();
            textBox_paid = new TextBox();
            button_exit = new Button();
            button_calculate = new Button();
            SuspendLayout();
            // 
            // comboBox_vehicle
            // 
            comboBox_vehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_vehicle.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_vehicle.FormattingEnabled = true;
            comboBox_vehicle.Items.AddRange(new object[] { "Wave Alpha", "Sirius", "Vision", "Lead", "Winner", "AirBlade 150", "Xe tải 9 tấn" });
            comboBox_vehicle.Location = new Point(123, 175);
            comboBox_vehicle.Name = "comboBox_vehicle";
            comboBox_vehicle.Size = new Size(176, 28);
            comboBox_vehicle.TabIndex = 0;
            // 
            // comboBox_fuel
            // 
            comboBox_fuel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_fuel.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_fuel.FormattingEnabled = true;
            comboBox_fuel.Items.AddRange(new object[] { "Xăng RON 95-III", "Xăng E5 RON 92-II", "Dầu DO 0,05S-II" });
            comboBox_fuel.Location = new Point(496, 175);
            comboBox_fuel.Name = "comboBox_fuel";
            comboBox_fuel.Size = new Size(176, 28);
            comboBox_fuel.TabIndex = 1;
            // 
            // textBox_distance
            // 
            textBox_distance.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_distance.Location = new Point(123, 368);
            textBox_distance.Name = "textBox_distance";
            textBox_distance.ReadOnly = true;
            textBox_distance.Size = new Size(176, 28);
            textBox_distance.TabIndex = 3;
            textBox_distance.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_paid
            // 
            textBox_paid.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_paid.Location = new Point(509, 368);
            textBox_paid.Name = "textBox_paid";
            textBox_paid.ReadOnly = true;
            textBox_paid.Size = new Size(163, 28);
            textBox_paid.TabIndex = 4;
            textBox_paid.TextAlign = HorizontalAlignment.Center;
            // 
            // button_exit
            // 
            button_exit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(496, 266);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(176, 52);
            button_exit.TabIndex = 8;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_calculate
            // 
            button_calculate.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_calculate.Location = new Point(123, 266);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(176, 52);
            button_calculate.TabIndex = 9;
            button_calculate.Text = "ĐỔ ĐẦY BÌNH";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_calculate);
            Controls.Add(button_exit);
            Controls.Add(textBox_paid);
            Controls.Add(textBox_distance);
            Controls.Add(comboBox_fuel);
            Controls.Add(comboBox_vehicle);
            Name = "Lab01_Bai05";
            Text = "Lab01_Bai05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_vehicle;
        private ComboBox comboBox_fuel;
        private TextBox textBox_distance;
        private TextBox textBox_paid;
        private Button button_exit;
        private Button button_calculate;
    }
}