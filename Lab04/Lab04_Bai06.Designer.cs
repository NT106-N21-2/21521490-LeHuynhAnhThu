namespace Lab04
{
    partial class Lab04_Bai06
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
            progressBar = new ProgressBar();
            panel_web = new Panel();
            SuspendLayout();
            // 
            // textBox_url
            // 
            textBox_url.Location = new Point(21, 21);
            textBox_url.Name = "textBox_url";
            textBox_url.Size = new Size(643, 27);
            textBox_url.TabIndex = 7;
            // 
            // button_get
            // 
            button_get.Location = new Point(703, 21);
            button_get.Name = "button_get";
            button_get.Size = new Size(85, 27);
            button_get.TabIndex = 6;
            button_get.Text = "GET";
            button_get.UseVisualStyleBackColor = true;
            button_get.Click += button_get_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(24, 416);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(764, 22);
            progressBar.TabIndex = 8;
            // 
            // panel_web
            // 
            panel_web.AutoScroll = true;
            panel_web.Location = new Point(24, 81);
            panel_web.Name = "panel_web";
            panel_web.Size = new Size(764, 329);
            panel_web.TabIndex = 9;
            panel_web.Click += panel_web_Click;
            // 
            // Lab04_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_web);
            Controls.Add(progressBar);
            Controls.Add(textBox_url);
            Controls.Add(button_get);
            Name = "Lab04_Bai06";
            Text = "Lab04_Bai06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_url;
        private Button button_get;
        private ProgressBar progressBar;
        private Panel panel_web;
    }
}