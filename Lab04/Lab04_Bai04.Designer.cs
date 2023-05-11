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
            textBox_url.Location = new Point(12, 25);
            textBox_url.Name = "textBox_url";
            textBox_url.Size = new Size(397, 27);
            textBox_url.TabIndex = 5;
            // 
            // button_get
            // 
            button_get.Location = new Point(426, 25);
            button_get.Name = "button_get";
            button_get.Size = new Size(85, 27);
            button_get.TabIndex = 4;
            button_get.Text = "View Web";
            button_get.UseVisualStyleBackColor = true;
            button_get.Click += button_get_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 72);
            webView21.Name = "webView21";
            webView21.Size = new Size(743, 353);
            webView21.TabIndex = 6;
            webView21.ZoomFactor = 1D;
            // 
            // button_view
            // 
            button_view.Location = new Point(517, 25);
            button_view.Name = "button_view";
            button_view.Size = new Size(99, 27);
            button_view.TabIndex = 7;
            button_view.Text = "View Source";
            button_view.UseVisualStyleBackColor = true;
            button_view.Click += button_view_Click;
            // 
            // button_download
            // 
            button_download.Location = new Point(622, 24);
            button_download.Name = "button_download";
            button_download.Size = new Size(133, 28);
            button_download.TabIndex = 8;
            button_download.Text = "Download HTML";
            button_download.UseVisualStyleBackColor = true;
            button_download.Click += button_download_Click;
            // 
            // Lab04_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(button_download);
            Controls.Add(button_view);
            Controls.Add(webView21);
            Controls.Add(textBox_url);
            Controls.Add(button_get);
            Name = "Lab04_Bai04";
            Text = "Lab04_Bai04";
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