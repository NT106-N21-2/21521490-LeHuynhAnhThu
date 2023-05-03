namespace Lab03
{
    partial class Bai04_Client
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
            richTextBox1 = new RichTextBox();
            button_disconnect = new Button();
            button_send = new Button();
            button_connect = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(282, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(466, 247);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // button_disconnect
            // 
            button_disconnect.Location = new Point(53, 271);
            button_disconnect.Name = "button_disconnect";
            button_disconnect.Size = new Size(128, 61);
            button_disconnect.TabIndex = 6;
            button_disconnect.Text = "Disconnect";
            button_disconnect.UseVisualStyleBackColor = true;
            button_disconnect.Click += button_disconnect_Click;
            // 
            // button_send
            // 
            button_send.Location = new Point(53, 187);
            button_send.Name = "button_send";
            button_send.Size = new Size(128, 59);
            button_send.TabIndex = 5;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // button_connect
            // 
            button_connect.Location = new Point(53, 102);
            button_connect.Name = "button_connect";
            button_connect.Size = new Size(128, 56);
            button_connect.TabIndex = 4;
            button_connect.Text = "Connect";
            button_connect.UseVisualStyleBackColor = true;
            button_connect.Click += button_connect_Click;
            // 
            // Bai04_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button_disconnect);
            Controls.Add(button_send);
            Controls.Add(button_connect);
            Name = "Bai04_Client";
            Text = "Bai04_Client";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_disconnect;
        private Button button_send;
        private Button button_connect;
    }
}