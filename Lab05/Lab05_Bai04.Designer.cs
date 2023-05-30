namespace Lab05
{
    partial class Lab05_Bai04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab05_Bai04));
            listView_mail = new ListView();
            panel_login = new Panel();
            button_refresh = new Button();
            button_logout = new Button();
            button_send = new Button();
            textBox_usermail = new TextBox();
            textBox_password = new TextBox();
            button_login = new Button();
            panel_setting = new Panel();
            textBox_portsend = new TextBox();
            textBox_hostsend = new TextBox();
            textBox_hostget = new TextBox();
            textBox_portget = new TextBox();
            panel_login.SuspendLayout();
            panel_setting.SuspendLayout();
            SuspendLayout();
            // 
            // listView_mail
            // 
            listView_mail.BackColor = Color.FromArgb(250, 244, 228);
            listView_mail.Location = new Point(-5, 253);
            listView_mail.Name = "listView_mail";
            listView_mail.Size = new Size(880, 238);
            listView_mail.TabIndex = 0;
            listView_mail.UseCompatibleStateImageBehavior = false;
            listView_mail.View = View.Details;
            listView_mail.SelectedIndexChanged += listView_mail_SelectedIndexChanged;
            // 
            // panel_login
            // 
            panel_login.BackColor = Color.Transparent;
            panel_login.Controls.Add(button_refresh);
            panel_login.Controls.Add(button_logout);
            panel_login.Controls.Add(button_send);
            panel_login.Controls.Add(textBox_usermail);
            panel_login.Controls.Add(textBox_password);
            panel_login.Controls.Add(button_login);
            panel_login.Location = new Point(29, 42);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(385, 147);
            panel_login.TabIndex = 1;
            // 
            // button_refresh
            // 
            button_refresh.BackColor = Color.FromArgb(250, 244, 228);
            button_refresh.Location = new Point(138, 102);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(103, 29);
            button_refresh.TabIndex = 7;
            button_refresh.Text = "Refresh";
            button_refresh.UseVisualStyleBackColor = false;
            button_refresh.Visible = false;
            button_refresh.Click += button_refresh_Click;
            // 
            // button_logout
            // 
            button_logout.BackColor = Color.FromArgb(250, 244, 228);
            button_logout.Location = new Point(259, 102);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(103, 29);
            button_logout.TabIndex = 6;
            button_logout.Text = "Đăng xuất";
            button_logout.UseVisualStyleBackColor = false;
            button_logout.Visible = false;
            button_logout.Click += button_logout_Click;
            // 
            // button_send
            // 
            button_send.BackColor = Color.FromArgb(250, 244, 228);
            button_send.Location = new Point(17, 102);
            button_send.Name = "button_send";
            button_send.Size = new Size(103, 29);
            button_send.TabIndex = 4;
            button_send.Text = "Gửi mail";
            button_send.UseVisualStyleBackColor = false;
            button_send.Visible = false;
            button_send.Click += button_send_Click;
            // 
            // textBox_usermail
            // 
            textBox_usermail.BackColor = Color.FromArgb(250, 244, 228);
            textBox_usermail.BorderStyle = BorderStyle.None;
            textBox_usermail.Location = new Point(112, 12);
            textBox_usermail.Name = "textBox_usermail";
            textBox_usermail.Size = new Size(233, 20);
            textBox_usermail.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.FromArgb(250, 244, 228);
            textBox_password.BorderStyle = BorderStyle.None;
            textBox_password.Location = new Point(113, 57);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(233, 20);
            textBox_password.TabIndex = 0;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(250, 244, 228);
            button_login.Location = new Point(260, 102);
            button_login.Name = "button_login";
            button_login.Size = new Size(103, 29);
            button_login.TabIndex = 1;
            button_login.Text = "Đăng nhập";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // panel_setting
            // 
            panel_setting.BackColor = Color.Transparent;
            panel_setting.Controls.Add(textBox_portsend);
            panel_setting.Controls.Add(textBox_hostsend);
            panel_setting.Controls.Add(textBox_hostget);
            panel_setting.Controls.Add(textBox_portget);
            panel_setting.Location = new Point(443, 42);
            panel_setting.Name = "panel_setting";
            panel_setting.Size = new Size(377, 147);
            panel_setting.TabIndex = 2;
            // 
            // textBox_portsend
            // 
            textBox_portsend.BackColor = Color.FromArgb(250, 244, 228);
            textBox_portsend.BorderStyle = BorderStyle.None;
            textBox_portsend.Location = new Point(249, 59);
            textBox_portsend.Name = "textBox_portsend";
            textBox_portsend.ReadOnly = true;
            textBox_portsend.Size = new Size(97, 20);
            textBox_portsend.TabIndex = 4;
            textBox_portsend.Text = "465";
            
            // 
            // textBox_hostsend
            // 
            textBox_hostsend.BackColor = Color.FromArgb(250, 244, 228);
            textBox_hostsend.BorderStyle = BorderStyle.None;
            textBox_hostsend.Location = new Point(242, 15);
            textBox_hostsend.Name = "textBox_hostsend";
            textBox_hostsend.ReadOnly = true;
            textBox_hostsend.Size = new Size(120, 20);
            textBox_hostsend.TabIndex = 3;
            textBox_hostsend.Text = "smtp.gmail.com";
            // 
            // textBox_hostget
            // 
            textBox_hostget.BackColor = Color.FromArgb(250, 244, 228);
            textBox_hostget.BorderStyle = BorderStyle.None;
            textBox_hostget.Location = new Point(63, 14);
            textBox_hostget.Name = "textBox_hostget";
            textBox_hostget.ReadOnly = true;
            textBox_hostget.Size = new Size(113, 20);
            textBox_hostget.TabIndex = 2;
            textBox_hostget.Text = "imap.gmail.com";
            // 
            // textBox_portget
            // 
            textBox_portget.BackColor = Color.FromArgb(250, 244, 228);
            textBox_portget.BorderStyle = BorderStyle.None;
            textBox_portget.Location = new Point(70, 58);
            textBox_portget.Name = "textBox_portget";
            textBox_portget.ReadOnly = true;
            textBox_portget.Size = new Size(99, 20);
            textBox_portget.TabIndex = 1;
            textBox_portget.Text = "993";
            // 
            // Lab05_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 244, 228);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(873, 516);
            Controls.Add(panel_setting);
            Controls.Add(panel_login);
            Controls.Add(listView_mail);
            Name = "Lab05_Bai04";
            Text = "Lab05_Bai04";
           
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            panel_setting.ResumeLayout(false);
            panel_setting.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView_mail;
        private Panel panel_login;
        private Button button_login;
        private Button button_sendmail;
        private Panel panel_setting;
        private TextBox textBox_usermail;
        private TextBox textBox_hostget;
        private TextBox textBox_portget;
        private TextBox textBox_password;
        private TextBox textBox_portsend;
        private TextBox textBox_hostsend;
        private Button button_logout;
        private Button button_refresh;
        private Button button_send;
    }
}