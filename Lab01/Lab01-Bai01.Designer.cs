namespace Lab01
{
    partial class Lab01_Bai01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai01));
            textBox_num2 = new TextBox();
            textBox_num1 = new TextBox();
            textBox_sum = new TextBox();
            button_calculate = new Button();
            button_exit = new Button();
            button_delete = new Button();
            SuspendLayout();
            // 
            // textBox_num2
            // 
            textBox_num2.BackColor = Color.FromArgb(252, 248, 241);
            textBox_num2.BorderStyle = BorderStyle.None;
            textBox_num2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num2.Location = new Point(700, 112);
            textBox_num2.Name = "textBox_num2";
            textBox_num2.Size = new Size(172, 27);
            textBox_num2.TabIndex = 2;
            textBox_num2.TextAlign = HorizontalAlignment.Center;
            textBox_num2.KeyPress += textBox_num2_KeyPress;
            // 
            // textBox_num1
            // 
            textBox_num1.BackColor = Color.FromArgb(252, 248, 241);
            textBox_num1.BorderStyle = BorderStyle.None;
            textBox_num1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num1.Location = new Point(700, 202);
            textBox_num1.Name = "textBox_num1";
            textBox_num1.Size = new Size(172, 27);
            textBox_num1.TabIndex = 3;
            textBox_num1.TextAlign = HorizontalAlignment.Center;
            textBox_num1.KeyPress += textBox_num1_KeyPress_1;
            // 
            // textBox_sum
            // 
            textBox_sum.BackColor = Color.FromArgb(252, 248, 241);
            textBox_sum.BorderStyle = BorderStyle.None;
            textBox_sum.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_sum.Location = new Point(700, 389);
            textBox_sum.Name = "textBox_sum";
            textBox_sum.ReadOnly = true;
            textBox_sum.Size = new Size(172, 27);
            textBox_sum.TabIndex = 4;
            textBox_sum.TextAlign = HorizontalAlignment.Center;
            // 
            // button_calculate
            // 
            button_calculate.BackColor = Color.FromArgb(250, 205, 204);
            button_calculate.FlatStyle = FlatStyle.Flat;
            button_calculate.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_calculate.Location = new Point(631, 269);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(103, 74);
            button_calculate.TabIndex = 5;
            button_calculate.Text = "TÍNH";
            button_calculate.UseVisualStyleBackColor = false;
            button_calculate.Click += button_calculate_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(250, 205, 204);
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(754, 269);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(135, 74);
            button_exit.TabIndex = 9;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(250, 205, 204);
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(509, 269);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(101, 74);
            button_delete.TabIndex = 8;
            button_delete.Text = "XÓA";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 519);
            Controls.Add(button_exit);
            Controls.Add(button_delete);
            Controls.Add(button_calculate);
            Controls.Add(textBox_sum);
            Controls.Add(textBox_num1);
            Controls.Add(textBox_num2);
            Name = "Lab01_Bai01";
            Text = "Lab01_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_num2;
        private TextBox textBox_num1;
        private TextBox textBox_sum;
        private Button button_calculate;
        private Button button_exit;
        private Button button_delete;
    }
}