namespace Lab03_Bai05
{
    partial class Bai05_ClientForm
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
            textBox_message = new TextBox();
            button_send = new Button();
            richTextBox_chat = new RichTextBox();
            textBox_name = new TextBox();
            SuspendLayout();
            // 
            // textBox_message
            // 
            textBox_message.Location = new Point(36, 342);
            textBox_message.Name = "textBox_message";
            textBox_message.Size = new Size(291, 27);
            textBox_message.TabIndex = 0;
            // 
            // button_send
            // 
            button_send.Location = new Point(363, 342);
            button_send.Name = "button_send";
            button_send.Size = new Size(90, 31);
            button_send.TabIndex = 1;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // richTextBox_chat
            // 
            richTextBox_chat.Location = new Point(26, 21);
            richTextBox_chat.Name = "richTextBox_chat";
            richTextBox_chat.Size = new Size(649, 199);
            richTextBox_chat.TabIndex = 2;
            richTextBox_chat.Text = "";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(41, 296);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(229, 27);
            textBox_name.TabIndex = 0;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_name);
            Controls.Add(richTextBox_chat);
            Controls.Add(button_send);
            Controls.Add(textBox_message);
            Name = "ClientForm";
            Text = "ClientForm";
            FormClosing += ClientForm_FormClosing;
            Load += ClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_message;
        private Button button_send;
        private RichTextBox richTextBox_chat;
        private TextBox textBox_name;
    }
}