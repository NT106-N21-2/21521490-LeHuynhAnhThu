namespace Lab05
{
    partial class Lab05_Bai02
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
            button_Login = new Button();
            textBox_Email = new TextBox();
            textBox_Password = new TextBox();
            listView1 = new ListView();
            label_Total = new Label();
            checkBox_Showpass = new CheckBox();
            SuspendLayout();
            // 
            // button_Login
            // 
            button_Login.Location = new Point(576, 54);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 29);
            button_Login.TabIndex = 0;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(81, 22);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(326, 27);
            textBox_Email.TabIndex = 1;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(81, 66);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(326, 27);
            textBox_Password.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(23, 116);
            listView1.Name = "listView1";
            listView1.Size = new Size(789, 301);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Location = new Point(437, 72);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(0, 20);
            label_Total.TabIndex = 4;
            // 
            // checkBox_Showpass
            // 
            checkBox_Showpass.AutoSize = true;
            checkBox_Showpass.Cursor = Cursors.No;
            checkBox_Showpass.Location = new Point(376, 69);
            checkBox_Showpass.Name = "checkBox_Showpass";
            checkBox_Showpass.Size = new Size(18, 17);
            checkBox_Showpass.TabIndex = 5;
            checkBox_Showpass.UseVisualStyleBackColor = true;
            checkBox_Showpass.CheckedChanged += checkBox_Showpass_CheckedChanged_1;
            // 
            // Lab05_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(checkBox_Showpass);
            Controls.Add(label_Total);
            Controls.Add(listView1);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Email);
            Controls.Add(button_Login);
            Name = "Lab05_Bai02";
            Text = "Lab05_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Login;
        private TextBox textBox_Email;
        private TextBox textBox_Password;
        private ListView listView1;
        private Label label_Total;
        private CheckBox checkBox_Showpass;
    }
}