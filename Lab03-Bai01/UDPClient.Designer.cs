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
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.richTextBox_message = new System.Windows.Forms.RichTextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(58, 69);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.ReadOnly = true;
            this.textBox_ip.Size = new System.Drawing.Size(264, 27);
            this.textBox_ip.TabIndex = 0;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(577, 69);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.ReadOnly = true;
            this.textBox_port.Size = new System.Drawing.Size(157, 27);
            this.textBox_port.TabIndex = 1;
            // 
            // richTextBox_message
            // 
            this.richTextBox_message.Location = new System.Drawing.Point(58, 177);
            this.richTextBox_message.Name = "richTextBox_message";
            this.richTextBox_message.Size = new System.Drawing.Size(676, 176);
            this.richTextBox_message.TabIndex = 2;
            this.richTextBox_message.Text = "";
            this.richTextBox_message.TextChanged += new System.EventHandler(this.richTextBox_message_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(60, 398);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(110, 27);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.richTextBox_message);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Name = "UDPClient";
            this.Text = "UDPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_ip;
        private TextBox textBox_port;
        private RichTextBox richTextBox_message;
        private Button button_send;
    }
}