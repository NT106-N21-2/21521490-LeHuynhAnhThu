namespace Lab05
{
    partial class Bai04_ViewMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04_ViewMail));
            webView_mail = new Microsoft.Web.WebView2.WinForms.WebView2();
            button_reply = new Button();
            textBox_from = new TextBox();
            textBox_to = new TextBox();
            ((System.ComponentModel.ISupportInitialize)webView_mail).BeginInit();
            SuspendLayout();
            // 
            // webView_mail
            // 
            webView_mail.AllowExternalDrop = true;
            webView_mail.BackColor = Color.FromArgb(250, 244, 228);
            webView_mail.CreationProperties = null;
            webView_mail.DefaultBackgroundColor = Color.White;
            webView_mail.ForeColor = SystemColors.ControlText;
            webView_mail.Location = new Point(38, 145);
            webView_mail.Name = "webView_mail";
            webView_mail.Size = new Size(766, 342);
            webView_mail.TabIndex = 0;
            webView_mail.ZoomFactor = 1D;
            // 
            // button_reply
            // 
            button_reply.BackColor = Color.Transparent;
            button_reply.FlatAppearance.BorderSize = 0;
            button_reply.FlatStyle = FlatStyle.Flat;
            button_reply.Location = new Point(589, 29);
            button_reply.Name = "button_reply";
            button_reply.Size = new Size(65, 44);
            button_reply.TabIndex = 1;
            button_reply.UseVisualStyleBackColor = false;
            button_reply.Click += button_reply_Click;
            // 
            // textBox_from
            // 
            textBox_from.BackColor = Color.FromArgb(244, 168, 46);
            textBox_from.BorderStyle = BorderStyle.None;
            textBox_from.Location = new Point(248, 29);
            textBox_from.Name = "textBox_from";
            textBox_from.Size = new Size(293, 20);
            textBox_from.TabIndex = 2;
            // 
            // textBox_to
            // 
            textBox_to.BackColor = Color.FromArgb(244, 168, 46);
            textBox_to.BorderStyle = BorderStyle.None;
            textBox_to.Location = new Point(250, 75);
            textBox_to.Name = "textBox_to";
            textBox_to.Size = new Size(293, 20);
            textBox_to.TabIndex = 3;
            // 
            // Bai04_ViewMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(830, 493);
            Controls.Add(textBox_to);
            Controls.Add(textBox_from);
            Controls.Add(button_reply);
            Controls.Add(webView_mail);
            Name = "Bai04_ViewMail";
            Text = "Bai04_ViewMail";
            Load += Bai04_ViewMail_Load;
            ((System.ComponentModel.ISupportInitialize)webView_mail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView_mail;
        private Button button_reply;
        private TextBox textBox_from;
        private TextBox textBox_to;
    }
}