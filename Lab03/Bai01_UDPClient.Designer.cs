namespace Lab03_Bai01
{
    partial class Bai01_UDPClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai01_UDPClient));
            textBox_ip = new TextBox();
            textBox_port = new TextBox();
            richTextBox_message = new RichTextBox();
            button_send = new Button();
            SuspendLayout();
            // 
            // textBox_ip
            // 
            textBox_ip.BorderStyle = BorderStyle.None;
            textBox_ip.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_ip.ForeColor = Color.Transparent;
            textBox_ip.Location = new Point(118, 97);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.ReadOnly = true;
            textBox_ip.Size = new Size(165, 20);
            textBox_ip.TabIndex = 0;
            // 
            // textBox_port
            // 
            textBox_port.BorderStyle = BorderStyle.None;
            textBox_port.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_port.Location = new Point(600, 97);
            textBox_port.Name = "textBox_port";
            textBox_port.ReadOnly = true;
            textBox_port.Size = new Size(117, 20);
            textBox_port.TabIndex = 1;
            // 
            // richTextBox_message
            // 
            richTextBox_message.BorderStyle = BorderStyle.None;
            richTextBox_message.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_message.Location = new Point(118, 220);
            richTextBox_message.Name = "richTextBox_message";
            richTextBox_message.Size = new Size(599, 134);
            richTextBox_message.TabIndex = 2;
            richTextBox_message.Text = "";
            // 
            // button_send
            // 
            button_send.BackColor = Color.Transparent;
            button_send.FlatAppearance.BorderSize = 0;
            button_send.FlatStyle = FlatStyle.Flat;
            button_send.ForeColor = SystemColors.ControlText;
            button_send.Location = new Point(653, 380);
            button_send.Name = "button_send";
            button_send.Size = new Size(81, 47);
            button_send.TabIndex = 3;
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // Bai01_UDPClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button_send);
            Controls.Add(richTextBox_message);
            Controls.Add(textBox_port);
            Controls.Add(textBox_ip);
            Name = "Bai01_UDPClient";
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