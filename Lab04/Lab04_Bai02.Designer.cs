namespace Lab04
{
    partial class Lab04_Bai02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab04_Bai02));
            button_post = new Button();
            textBox_url = new TextBox();
            textBox_data = new TextBox();
            richTextBox_web = new RichTextBox();
            SuspendLayout();
            // 
            // button_post
            // 
            button_post.BackColor = Color.Transparent;
            button_post.FlatAppearance.BorderSize = 0;
            button_post.FlatStyle = FlatStyle.Flat;
            button_post.Location = new Point(592, 62);
            button_post.Name = "button_post";
            button_post.Size = new Size(135, 77);
            button_post.TabIndex = 0;
            button_post.UseVisualStyleBackColor = false;
            button_post.Click += button_post_Click;
            // 
            // textBox_url
            // 
            textBox_url.BackColor = Color.Pink;
            textBox_url.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_url.Location = new Point(63, 63);
            textBox_url.Multiline = true;
            textBox_url.Name = "textBox_url";
            textBox_url.Size = new Size(483, 35);
            textBox_url.TabIndex = 1;
            textBox_url.TextChanged += textBox_url_TextChanged;
            // 
            // textBox_data
            // 
            textBox_data.BackColor = Color.Pink;
            textBox_data.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            textBox_data.Location = new Point(64, 112);
            textBox_data.Multiline = true;
            textBox_data.Name = "textBox_data";
            textBox_data.Size = new Size(483, 32);
            textBox_data.TabIndex = 2;
            // 
            // richTextBox_web
            // 
            richTextBox_web.BackColor = Color.Pink;
            richTextBox_web.Location = new Point(64, 167);
            richTextBox_web.Name = "richTextBox_web";
            richTextBox_web.ReadOnly = true;
            richTextBox_web.Size = new Size(687, 254);
            richTextBox_web.TabIndex = 3;
            richTextBox_web.Text = "";
            // 
            // Lab04_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(814, 450);
            Controls.Add(richTextBox_web);
            Controls.Add(textBox_data);
            Controls.Add(textBox_url);
            Controls.Add(button_post);
            Name = "Lab04_Bai02";
            Text = "Lab04_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_post;
        private TextBox textBox_url;
        private TextBox textBox_data;
        private RichTextBox richTextBox_web;
    }
}