namespace Lab05
{
    partial class Lab05_Bai01
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
            button_send = new Button();
            textBox_from = new TextBox();
            textBox_subject = new TextBox();
            textBox_to = new TextBox();
            richTextBox_body = new RichTextBox();
            SuspendLayout();
            // 
            // button_send
            // 
            button_send.Location = new Point(12, 22);
            button_send.Name = "button_send";
            button_send.Size = new Size(75, 29);
            button_send.TabIndex = 0;
            button_send.Text = "SEND";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // textBox_from
            // 
            textBox_from.Location = new Point(188, 24);
            textBox_from.Name = "textBox_from";
            textBox_from.Size = new Size(575, 27);
            textBox_from.TabIndex = 1;
            // 
            // textBox_subject
            // 
            textBox_subject.Location = new Point(102, 130);
            textBox_subject.Name = "textBox_subject";
            textBox_subject.Size = new Size(661, 27);
            textBox_subject.TabIndex = 2;
            // 
            // textBox_to
            // 
            textBox_to.Location = new Point(188, 73);
            textBox_to.Name = "textBox_to";
            textBox_to.Size = new Size(575, 27);
            textBox_to.TabIndex = 3;
            // 
            // richTextBox_body
            // 
            richTextBox_body.Location = new Point(102, 173);
            richTextBox_body.Name = "richTextBox_body";
            richTextBox_body.Size = new Size(661, 265);
            richTextBox_body.TabIndex = 4;
            richTextBox_body.Text = "";
            // 
            // Lab05_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_body);
            Controls.Add(textBox_to);
            Controls.Add(textBox_subject);
            Controls.Add(textBox_from);
            Controls.Add(button_send);
            Name = "Lab05_Bai01";
            Text = "Lab05_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_send;
        private TextBox textBox_from;
        private TextBox textBox_subject;
        private TextBox textBox_to;
        private RichTextBox richTextBox_body;
    }
}