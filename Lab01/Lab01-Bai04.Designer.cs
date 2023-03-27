namespace Lab01
{
    partial class Lab01_Bai04
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
            button_read = new Button();
            button_exit = new Button();
            button_delete = new Button();
            textBox_read = new TextBox();
            textBox_num = new TextBox();
            SuspendLayout();
            // 
            // button_read
            // 
            button_read.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_read.Location = new Point(679, 109);
            button_read.Name = "button_read";
            button_read.Size = new Size(84, 35);
            button_read.TabIndex = 14;
            button_read.Text = "ĐỌC";
            button_read.UseVisualStyleBackColor = true;
            button_read.Click += button_read_Click;
            // 
            // button_exit
            // 
            button_exit.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(679, 321);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(84, 35);
            button_exit.TabIndex = 13;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(679, 215);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(84, 35);
            button_delete.TabIndex = 12;
            button_delete.Text = "XÓA";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // textBox_read
            // 
            textBox_read.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_read.Location = new Point(182, 282);
            textBox_read.Name = "textBox_read";
            textBox_read.ReadOnly = true;
            textBox_read.Size = new Size(399, 28);
            textBox_read.TabIndex = 11;
            textBox_read.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_num
            // 
            textBox_num.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num.Location = new Point(475, 162);
            textBox_num.Name = "textBox_num";
            textBox_num.Size = new Size(106, 28);
            textBox_num.TabIndex = 10;
            textBox_num.TextAlign = HorizontalAlignment.Center;
            textBox_num.KeyPress += textBox_num_KeyPress;
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_read);
            Controls.Add(button_exit);
            Controls.Add(button_delete);
            Controls.Add(textBox_read);
            Controls.Add(textBox_num);
            Name = "Lab01_Bai04";
            Text = "Lab01_Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_read;
        private Button button_exit;
        private Button button_delete;
        private TextBox textBox_read;
        private TextBox textBox_num;
    }
}