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
            textBox_from.Location = new Point(100, 12);
            textBox_from.Name = "textBox_from";
            textBox_from.Size = new Size(688, 27);
            textBox_from.TabIndex = 0;
            // 
            // richTextBox_body
            // 
            richTextBox_body.Location = new Point(100, 174);
            richTextBox_body.Name = "richTextBox_body";
            richTextBox_body.Size = new Size(688, 260);
            richTextBox_body.TabIndex = 1;
            richTextBox_body.Text = "";
            // 
            // button_open
            // 
            button_open.Location = new Point(694, 440);
            button_open.Name = "button_open";
            button_open.Size = new Size(94, 29);
            button_open.TabIndex = 2;
            button_open.Text = "Browser";
            button_open.UseVisualStyleBackColor = true;
            button_open.Click += button_open_Click;
            // 
            // button_send
            // 
            button_send.Location = new Point(694, 475);
            button_send.Name = "button_send";
            button_send.Size = new Size(94, 29);
            button_send.TabIndex = 3;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // textBox_attachment
            // 
            textBox_attachment.Location = new Point(100, 440);
            textBox_attachment.Name = "textBox_attachment";
            textBox_attachment.Size = new Size(588, 27);
            textBox_attachment.TabIndex = 4;
            // 
            // textBox_subject
            // 
            textBox_subject.Location = new Point(100, 111);
            textBox_subject.Name = "textBox_subject";
            textBox_subject.Size = new Size(688, 27);
            textBox_subject.TabIndex = 5;
            // 
            // textBox_to
            // 
            textBox_to.Location = new Point(100, 78);
            textBox_to.Name = "textBox_to";
            textBox_to.Size = new Size(688, 27);
            textBox_to.TabIndex = 6;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(100, 45);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(688, 27);
            textBox_name.TabIndex = 7;
            // 
            // checkBox_html
            // 
            checkBox_html.AutoSize = true;
            checkBox_html.Location = new Point(100, 144);
            checkBox_html.Name = "checkBox_html";
            checkBox_html.Size = new Size(70, 24);
            checkBox_html.TabIndex = 8;
            checkBox_html.Text = "HTML";
            checkBox_html.UseVisualStyleBackColor = true;
            // 
            // Bai05_SendMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(checkBox_html);
            Controls.Add(textBox_name);
            Controls.Add(textBox_to);
            Controls.Add(textBox_subject);
            Controls.Add(textBox_attachment);
            Controls.Add(button_send);
            Controls.Add(button_open);
            Controls.Add(richTextBox_body);
            Controls.Add(textBox_from);
            Name = "Bai05_SendMail";
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