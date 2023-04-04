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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai05));
            comboBox_vehicle = new ComboBox();
            comboBox_fuel = new ComboBox();
            textBox_distance = new TextBox();
            textBox_paid = new TextBox();
            button_exit = new Button();
            button_calculate = new Button();
            button_delete = new Button();
            SuspendLayout();
            // 
            // comboBox_vehicle
            // 
            comboBox_vehicle.BackColor = Color.FromArgb(252, 248, 241);
            comboBox_vehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_vehicle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_vehicle.FormattingEnabled = true;
            comboBox_vehicle.Items.AddRange(new object[] { "Wave Alpha", "Sirius", "Vision", "Lead", "Winner", "AirBlade 150", "Xe tải 9 tấn" });
            comboBox_vehicle.Location = new Point(88, 217);
            comboBox_vehicle.Name = "comboBox_vehicle";
            comboBox_vehicle.Size = new Size(209, 30);
            comboBox_vehicle.TabIndex = 0;
            // 
            // comboBox_fuel
            // 
            comboBox_fuel.BackColor = Color.FromArgb(252, 248, 241);
            comboBox_fuel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_fuel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_fuel.FormattingEnabled = true;
            comboBox_fuel.ItemHeight = 22;
            comboBox_fuel.Items.AddRange(new object[] { "Xăng RON 95-III", "Xăng E5 RON 92-II", "Dầu DO 0,05S-II" });
            comboBox_fuel.Location = new Point(644, 217);
            comboBox_fuel.Name = "comboBox_fuel";
            comboBox_fuel.Size = new Size(208, 30);
            comboBox_fuel.TabIndex = 1;
            // 
            // textBox_distance
            // 
            textBox_distance.BackColor = Color.FromArgb(252, 248, 241);
            textBox_distance.BorderStyle = BorderStyle.None;
            textBox_distance.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_distance.Location = new Point(117, 478);
            textBox_distance.Name = "textBox_distance";
            textBox_distance.ReadOnly = true;
            textBox_distance.Size = new Size(160, 27);
            textBox_distance.TabIndex = 3;
            textBox_distance.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_paid
            // 
            textBox_paid.BackColor = Color.FromArgb(252, 248, 241);
            textBox_paid.BorderStyle = BorderStyle.None;
            textBox_paid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_paid.Location = new Point(612, 478);
            textBox_paid.Name = "textBox_paid";
            textBox_paid.ReadOnly = true;
            textBox_paid.Size = new Size(163, 27);
            textBox_paid.TabIndex = 4;
            textBox_paid.TextAlign = HorizontalAlignment.Center;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(250, 205, 204);
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(365, 330);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(224, 69);
            button_exit.TabIndex = 8;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button_calculate
            // 
            button_calculate.BackColor = Color.FromArgb(250, 205, 204);
            button_calculate.FlatStyle = FlatStyle.Flat;
            button_calculate.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_calculate.Location = new Point(365, 255);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(224, 69);
            button_calculate.TabIndex = 9;
            button_calculate.Text = "ĐỔ ĐẦY BÌNH";
            button_calculate.UseVisualStyleBackColor = false;
            button_calculate.Click += button_calculate_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(250, 205, 204);
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(365, 179);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(224, 70);
            button_delete.TabIndex = 13;
            button_delete.Text = "XÓA";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 519);
            Controls.Add(button_delete);
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
        private Button button_delete;
    }
}