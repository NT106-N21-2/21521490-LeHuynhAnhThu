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
            SuspendLayout();
            // 
            // textBox_num2
            // 
            textBox_num2.BackColor = Color.FromArgb(252, 248, 241);
            textBox_num2.BorderStyle = BorderStyle.None;
            textBox_num2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num2.Location = new Point(700, 111);
            textBox_num2.Name = "textBox_num2";
            textBox_num2.Size = new Size(159, 27);
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
            textBox_num1.Size = new Size(159, 27);
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
            textBox_sum.Size = new Size(159, 27);
            textBox_sum.TabIndex = 4;
            textBox_sum.TextAlign = HorizontalAlignment.Center;
            // 
            // button_calculate
            // 
            button_calculate.BackColor = Color.FromArgb(196, 221, 246);
            button_calculate.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_calculate.Location = new Point(628, 267);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(157, 82);
            button_calculate.TabIndex = 5;
            button_calculate.Text = "TÍNH";
            button_calculate.UseVisualStyleBackColor = false;
            button_calculate.Click += button_calculate_Click;
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 519);
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
    }
}