namespace Lab04
{
    partial class Lab04_Bai04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab04_Bai04));
            textBox_url = new TextBox();
            button_get = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button_view = new Button();
            button_download = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // textBox_url
            // 
            textBox_url.BackColor = Color.Pink;
            textBox_url.Location = new Point(12, 48);
            textBox_url.Multiline = true;
            textBox_url.Name = "textBox_url";
            textBox_url.Size = new Size(437, 36);
            textBox_url.TabIndex = 5;
            // 
            // button_get
            // 
            button_get.BackColor = Color.Transparent;
            button_get.FlatAppearance.BorderSize = 0;
            button_get.FlatStyle = FlatStyle.Flat;
            button_get.Location = new Point(468, 48);
            button_get.Name = "button_get";
            button_get.Size = new Size(97, 36);
            button_get.TabIndex = 4;
            button_get.UseVisualStyleBackColor = false;
            button_get.Click += button_get_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = Color.Linen;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 106);
            webView21.Name = "webView21";
            webView21.Size = new Size(787, 332);
            webView21.TabIndex = 6;
            webView21.ZoomFactor = 1D;
            // 
            // button_view
            // 
            button_view.BackColor = Color.Transparent;
            button_view.FlatAppearance.BorderSize = 0;
            button_view.FlatStyle = FlatStyle.Flat;
            button_view.Location = new Point(590, 48);
            button_view.Name = "button_view";
            button_view.Size = new Size(99, 36);
            button_view.TabIndex = 7;
            button_view.UseVisualStyleBackColor = false;
            button_view.Click += button_view_Click;
            // 
            // button_download
            // 
            button_download.BackColor = Color.Transparent;
            button_download.FlatAppearance.BorderSize = 0;
            button_download.FlatStyle = FlatStyle.Flat;
            button_download.Location = new Point(695, 48);
            button_download.Name = "button_download";
            button_download.Size = new Size(102, 36);
            button_download.TabIndex = 8;
            button_download.UseVisualStyleBackColor = false;
            button_download.Click += button_download_Click;
            // 
            // Lab04_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(811, 450);
            Controls.Add(button_download);
            Controls.Add(button_view);
            Controls.Add(webView21);
            Controls.Add(textBox_url);
            Controls.Add(button_get);
            Name = "Lab04_Bai04";
            Text = "Lab04_Bai04";
            Load += Lab04_Bai04_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_url;
        private Button button_get;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button_view;
        private Button button_download;
    }
}