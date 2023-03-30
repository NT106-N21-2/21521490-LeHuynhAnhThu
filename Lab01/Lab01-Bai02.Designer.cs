namespace Lab01
{
    partial class Lab01_Bai02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai02));
            textBox_num1 = new TextBox();
            textBox_num2 = new TextBox();
            textBox_num3 = new TextBox();
            textBox_max = new TextBox();
            textBox_min = new TextBox();
            button_find = new Button();
            button_delete = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // textBox_num1
            // 
            textBox_num1.BackColor = Color.FromArgb(252, 248, 241);
            textBox_num1.BorderStyle = BorderStyle.None;
            textBox_num1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num1.Location = new Point(78, 262);
            textBox_num1.Name = "textBox_num1";
            textBox_num1.Size = new Size(159, 27);
            textBox_num1.TabIndex = 0;
            textBox_num1.TextAlign = HorizontalAlignment.Center;
            textBox_num1.KeyPress += textBox_num1_KeyPress;
            // 
            // textBox_num2
            // 
            textBox_num2.BackColor = Color.FromArgb(252, 248, 241);
            textBox_num2.BorderStyle = BorderStyle.None;
            textBox_num2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num2.Location = new Point(397, 263);
            textBox_num2.Name = "textBox_num2";
            textBox_num2.Size = new Size(155, 27);
            textBox_num2.TabIndex = 1;
            textBox_num2.TextAlign = HorizontalAlignment.Center;
            textBox_num2.KeyPress += textBox_num2_KeyPress;
            // 
            // textBox_num3
            // 
            textBox_num3.BackColor = Color.FromArgb(252, 248, 241);
            textBox_num3.BorderStyle = BorderStyle.None;
            textBox_num3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num3.Location = new Point(712, 263);
            textBox_num3.Name = "textBox_num3";
            textBox_num3.Size = new Size(151, 27);
            textBox_num3.TabIndex = 2;
            textBox_num3.TextAlign = HorizontalAlignment.Center;
            textBox_num3.KeyPress += textBox_num3_KeyPress;
            // 
            // textBox_max
            // 
            textBox_max.BackColor = Color.FromArgb(252, 248, 241);
            textBox_max.BorderStyle = BorderStyle.None;
            textBox_max.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_max.Location = new Point(261, 471);
            textBox_max.Name = "textBox_max";
            textBox_max.ReadOnly = true;
            textBox_max.Size = new Size(161, 27);
            textBox_max.TabIndex = 3;
            textBox_max.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_min
            // 
            textBox_min.BackColor = Color.FromArgb(252, 248, 241);
            textBox_min.BorderStyle = BorderStyle.None;
            textBox_min.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_min.Location = new Point(741, 470);
            textBox_min.Name = "textBox_min";
            textBox_min.ReadOnly = true;
            textBox_min.Size = new Size(158, 27);
            textBox_min.TabIndex = 4;
            textBox_min.TextAlign = HorizontalAlignment.Center;
            // 
            // button_find
            // 
            button_find.BackColor = Color.FromArgb(250, 205, 204);
            button_find.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_find.Location = new Point(64, 339);
            button_find.Name = "button_find";
            button_find.Size = new Size(173, 70);
            button_find.TabIndex = 5;
            button_find.Text = "TÌM";
            button_find.UseVisualStyleBackColor = false;
            button_find.Click += button_find_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(250, 205, 204);
            button_delete.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(375, 339);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(173, 70);
            button_delete.TabIndex = 6;
            button_delete.Text = "XÓA";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(250, 205, 204);
            button_exit.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(703, 339);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(173, 70);
            button_exit.TabIndex = 7;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 519);
            Controls.Add(button_exit);
            Controls.Add(button_delete);
            Controls.Add(button_find);
            Controls.Add(textBox_min);
            Controls.Add(textBox_max);
            Controls.Add(textBox_num3);
            Controls.Add(textBox_num2);
            Controls.Add(textBox_num1);
            Name = "Lab01_Bai02";
            Text = "Lab01_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_num1;
        private TextBox textBox_num2;
        private TextBox textBox_num3;
        private TextBox textBox_max;
        private TextBox textBox_min;
        private Button button_find;
        private Button button_delete;
        private Button button_exit;
    }
}