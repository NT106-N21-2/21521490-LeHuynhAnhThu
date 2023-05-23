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
            listView1 = new ListView();
            textBox_Password = new TextBox();
            textBox_Email = new TextBox();
            button_Login = new Button();
            label_Total = new Label();
            checkBox_Showpass = new CheckBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 122);
            listView1.Name = "listView1";
            listView1.Size = new Size(789, 301);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(64, 72);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(326, 27);
            textBox_Password.TabIndex = 6;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(64, 28);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(326, 27);
            textBox_Email.TabIndex = 5;
            // 
            // button_Login
            // 
            button_Login.Location = new Point(559, 60);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 29);
            button_Login.TabIndex = 4;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Location = new Point(436, 75);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(0, 20);
            label_Total.TabIndex = 8;
            // 
            // checkBox_Showpass
            // 
            checkBox_Showpass.AutoSize = true;
            checkBox_Showpass.Location = new Point(362, 76);
            checkBox_Showpass.Name = "checkBox_Showpass";
            checkBox_Showpass.Size = new Size(18, 17);
            checkBox_Showpass.TabIndex = 9;
            checkBox_Showpass.UseVisualStyleBackColor = true;
            checkBox_Showpass.CheckedChanged += checkBox_Showpass_CheckedChanged;
            // 
            // Lab05_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox_Showpass);
            Controls.Add(label_Total);
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
        private Label label_Total;
        private CheckBox checkBox_Showpass;
    }
}