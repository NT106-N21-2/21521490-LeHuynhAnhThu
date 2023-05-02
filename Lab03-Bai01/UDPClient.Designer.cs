namespace Lab03_Bai01
{
    partial class UDPClient
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
            textBox_ip = new TextBox();
            textBox_port = new TextBox();
            richTextBox_message = new RichTextBox();
            button_send = new Button();
            SuspendLayout();
            // 
            // textBox_ip
            // 
            textBox_ip.Location = new Point(58, 69);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.ReadOnly = true;
            textBox_ip.Size = new Size(264, 27);
            textBox_ip.TabIndex = 0;
            // 
            // textBox_port
            // 
            textBox_port.Location = new Point(577, 69);
            textBox_port.Name = "textBox_port";
            textBox_port.ReadOnly = true;
            textBox_port.Size = new Size(157, 27);
            textBox_port.TabIndex = 1;
            // 
            // richTextBox_message
            // 
            richTextBox_message.Location = new Point(58, 177);
            richTextBox_message.Name = "richTextBox_message";
            richTextBox_message.Size = new Size(676, 176);
            richTextBox_message.TabIndex = 2;
            richTextBox_message.Text = "";
            // 
            // button_send
            // 
            button_send.Location = new Point(60, 398);
            button_send.Name = "button_send";
            button_send.Size = new Size(110, 27);
            button_send.TabIndex = 3;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // UDPClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_send);
            Controls.Add(richTextBox_message);
            Controls.Add(textBox_port);
            Controls.Add(textBox_ip);
            Name = "UDPClient";
            Text = "UDPClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ip;
        private TextBox textBox_port;
        private RichTextBox richTextBox_message;
        private Button button_send;
    }
}