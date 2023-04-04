namespace Lab01
{
    partial class Lab01_Bai03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai03));
            textBox_num = new TextBox();
            textBox_read = new TextBox();
            button_delete = new Button();
            button_exit = new Button();
            button_read = new Button();
            SuspendLayout();
            // 
            // textBox_num
            // 
            textBox_num.BackColor = Color.FromArgb(252, 248, 241);
            textBox_num.BorderStyle = BorderStyle.None;
            textBox_num.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num.Location = new Point(696, 180);
            textBox_num.Name = "textBox_num";
            textBox_num.Size = new Size(160, 27);
            textBox_num.TabIndex = 1;
            textBox_num.TextAlign = HorizontalAlignment.Center;
            textBox_num.KeyPress += textBox_num_KeyPress;
            // 
            // textBox_read
            // 
            textBox_read.BackColor = Color.FromArgb(252, 248, 241);
            textBox_read.BorderStyle = BorderStyle.None;
            textBox_read.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_read.Location = new Point(672, 387);
            textBox_read.Name = "textBox_read";
            textBox_read.ReadOnly = true;
            textBox_read.Size = new Size(167, 27);
            textBox_read.TabIndex = 4;
            textBox_read.TextAlign = HorizontalAlignment.Center;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(196, 221, 246);
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(320, 239);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(96, 68);
            button_delete.TabIndex = 7;
            button_delete.Text = "XÓA";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(196, 221, 246);
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(732, 239);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(136, 68);
            button_exit.TabIndex = 8;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button_read
            // 
            button_read.BackColor = Color.FromArgb(196, 221, 246);
            button_read.FlatStyle = FlatStyle.Flat;
            button_read.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_read.Location = new Point(523, 239);
            button_read.Name = "button_read";
            button_read.Size = new Size(101, 68);
            button_read.TabIndex = 9;
            button_read.Text = "ĐỌC";
            button_read.UseVisualStyleBackColor = false;
            button_read.Click += button_read_Click;
            // 
            // Lab01_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 519);
            Controls.Add(button_read);
            Controls.Add(button_exit);
            Controls.Add(button_delete);
            Controls.Add(textBox_read);
            Controls.Add(textBox_num);
            Name = "Lab01_Bai03";
            Text = "Lab01_Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_num;
        private TextBox textBox_read;
        private Button button_delete;
        private Button button_exit;
        private Button button_read;
    }
}