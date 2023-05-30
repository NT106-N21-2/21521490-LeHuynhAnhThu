namespace Lab05
{
    partial class Bai04_SendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04_SendMail));
            textBox_from = new TextBox();
            richTextBox_body = new RichTextBox();
            button_open = new Button();
            button_send = new Button();
            textBox_attachment = new TextBox();
            textBox_subject = new TextBox();
            textBox_to = new TextBox();
            textBox_name = new TextBox();
            checkBox_html = new CheckBox();
            SuspendLayout();
            // 
            // textBox_from
            // 
            textBox_from.BackColor = Color.FromArgb(244, 168, 46);
            textBox_from.BorderStyle = BorderStyle.None;
            textBox_from.Location = new Point(114, 45);
            textBox_from.Name = "textBox_from";
            textBox_from.Size = new Size(264, 20);
            textBox_from.TabIndex = 0;
            // 
            // richTextBox_body
            // 
            richTextBox_body.BackColor = Color.FromArgb(250, 244, 228);
            richTextBox_body.BorderStyle = BorderStyle.None;
            richTextBox_body.Location = new Point(33, 187);
            richTextBox_body.Name = "richTextBox_body";
            richTextBox_body.Size = new Size(771, 247);
            richTextBox_body.TabIndex = 1;
            richTextBox_body.Text = "";
            // 
            // button_open
            // 
            button_open.BackColor = Color.Transparent;
            button_open.FlatAppearance.BorderSize = 0;
            button_open.FlatStyle = FlatStyle.Flat;
            button_open.Location = new Point(600, 446);
            button_open.Name = "button_open";
            button_open.Size = new Size(94, 29);
            button_open.TabIndex = 2;
            button_open.UseVisualStyleBackColor = false;
            button_open.Click += button_open_Click;
            // 
            // button_send
            // 
            button_send.BackColor = Color.Transparent;
            button_send.FlatAppearance.BorderSize = 0;
            button_send.FlatStyle = FlatStyle.Flat;
            button_send.Location = new Point(718, 447);
            button_send.Name = "button_send";
            button_send.Size = new Size(94, 29);
            button_send.TabIndex = 3;
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // textBox_attachment
            // 
            textBox_attachment.BackColor = Color.FromArgb(244, 168, 46);
            textBox_attachment.BorderStyle = BorderStyle.None;
            textBox_attachment.ForeColor = Color.Black;
            textBox_attachment.Location = new Point(34, 451);
            textBox_attachment.Name = "textBox_attachment";
            textBox_attachment.Size = new Size(531, 20);
            textBox_attachment.TabIndex = 4;
            textBox_attachment.TextChanged += textBox_attachment_TextChanged;
            // 
            // textBox_subject
            // 
            textBox_subject.BackColor = Color.FromArgb(244, 168, 46);
            textBox_subject.BorderStyle = BorderStyle.None;
            textBox_subject.Location = new Point(514, 94);
            textBox_subject.Name = "textBox_subject";
            textBox_subject.Size = new Size(274, 20);
            textBox_subject.TabIndex = 5;
            // 
            // textBox_to
            // 
            textBox_to.BackColor = Color.FromArgb(244, 168, 46);
            textBox_to.BorderStyle = BorderStyle.None;
            textBox_to.Location = new Point(514, 45);
            textBox_to.Name = "textBox_to";
            textBox_to.Size = new Size(274, 20);
            textBox_to.TabIndex = 6;
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.FromArgb(244, 168, 46);
            textBox_name.BorderStyle = BorderStyle.None;
            textBox_name.Location = new Point(114, 94);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(264, 20);
            textBox_name.TabIndex = 7;
            // 
            // checkBox_html
            // 
            checkBox_html.AutoSize = true;
            checkBox_html.BackColor = Color.FromArgb(250, 244, 228);
            checkBox_html.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox_html.ForeColor = SystemColors.HotTrack;
            checkBox_html.Location = new Point(746, 144);
            checkBox_html.Name = "checkBox_html";
            checkBox_html.Size = new Size(70, 24);
            checkBox_html.TabIndex = 8;
            checkBox_html.Text = "HTML";
            checkBox_html.UseVisualStyleBackColor = false;
            // 
            // Bai04_SendMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(842, 493);
            Controls.Add(checkBox_html);
            Controls.Add(textBox_name);
            Controls.Add(textBox_to);
            Controls.Add(textBox_subject);
            Controls.Add(textBox_attachment);
            Controls.Add(button_send);
            Controls.Add(button_open);
            Controls.Add(richTextBox_body);
            Controls.Add(textBox_from);
            Name = "Bai04_SendMail";
            Text = "Bai05_SendMail";
            Load += Bai05_SendMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_from;
        private RichTextBox richTextBox_body;
        private Button button_open;
        private Button button_send;
        private TextBox textBox_attachment;
        private TextBox textBox_subject;
        private TextBox textBox_to;
        private TextBox textBox_name;
        private CheckBox checkBox_html;
    }
}