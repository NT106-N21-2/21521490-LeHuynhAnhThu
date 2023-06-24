namespace Lab05
{
    partial class Lab05_Bai03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab05_Bai03));
            listView1 = new ListView();
            textBox_Password = new TextBox();
            textBox_Email = new TextBox();
            button_Login = new Button();
            checkBox_Showpass = new CheckBox();
            label_total = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 168);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 270);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // textBox_Password
            // 
            textBox_Password.BackColor = Color.FromArgb(239, 207, 49);
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.Location = new Point(192, 125);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(381, 20);
            textBox_Password.TabIndex = 6;
            // 
            // textBox_Email
            // 
            textBox_Email.BackColor = Color.FromArgb(239, 207, 49);
            textBox_Email.BorderStyle = BorderStyle.None;
            textBox_Email.Location = new Point(192, 56);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(381, 20);
            textBox_Email.TabIndex = 5;
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.Transparent;
            button_Login.FlatAppearance.BorderSize = 0;
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Location = new Point(683, 116);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 29);
            button_Login.TabIndex = 4;
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // checkBox_Showpass
            // 
            checkBox_Showpass.AutoSize = true;
            checkBox_Showpass.Location = new Point(583, 128);
            checkBox_Showpass.Name = "checkBox_Showpass";
            checkBox_Showpass.Size = new Size(18, 17);
            checkBox_Showpass.TabIndex = 9;
            checkBox_Showpass.UseVisualStyleBackColor = true;
            checkBox_Showpass.CheckedChanged += checkBox_Showpass_CheckedChanged;
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.BackColor = Color.Transparent;
            label_total.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_total.Location = new Point(734, 50);
            label_total.Name = "label_total";
            label_total.Size = new Size(0, 23);
            label_total.TabIndex = 10;
            label_total.UseWaitCursor = true;
            // 
            // Lab05_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label_total);
            Controls.Add(checkBox_Showpass);
            Controls.Add(listView1);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Email);
            Controls.Add(button_Login);
            Name = "Lab05_Bai03";
            Text = "Lab05_Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox textBox_Password;
        private TextBox textBox_Email;
        private Button button_Login;
        private CheckBox checkBox_Showpass;
        private Label label_total;
    }
}