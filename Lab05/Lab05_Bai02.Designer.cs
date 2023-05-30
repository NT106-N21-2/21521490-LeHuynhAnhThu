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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab05_Bai02));
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
            button_Login.BackColor = Color.Transparent;
            button_Login.FlatAppearance.BorderSize = 0;
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Location = new Point(681, 112);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 29);
            button_Login.TabIndex = 0;
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // textBox_Email
            // 
            textBox_Email.BackColor = Color.FromArgb(239, 207, 49);
            textBox_Email.BorderStyle = BorderStyle.None;
            textBox_Email.Location = new Point(186, 56);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(376, 20);
            textBox_Email.TabIndex = 1;
      
            // 
            // textBox_Password
            // 
            textBox_Password.BackColor = Color.FromArgb(239, 207, 49);
            textBox_Password.BorderStyle = BorderStyle.None;
            textBox_Password.Location = new Point(186, 129);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(387, 20);
            textBox_Password.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 175);
            listView1.Name = "listView1";
            listView1.Size = new Size(770, 272);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.BackColor = Color.FromArgb(239, 207, 49);
            label_Total.Location = new Point(437, 72);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(0, 20);
            label_Total.TabIndex = 4;
            // 
            // checkBox_Showpass
            // 
            checkBox_Showpass.AutoSize = true;
            checkBox_Showpass.BackColor = Color.FromArgb(239, 207, 49);
            checkBox_Showpass.Cursor = Cursors.No;
            checkBox_Showpass.Location = new Point(579, 130);
            checkBox_Showpass.Name = "checkBox_Showpass";
            checkBox_Showpass.Size = new Size(18, 17);
            checkBox_Showpass.TabIndex = 5;
            checkBox_Showpass.UseVisualStyleBackColor = false;
            checkBox_Showpass.CheckedChanged += checkBox_Showpass_CheckedChanged_1;
            // 
            // Lab05_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
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