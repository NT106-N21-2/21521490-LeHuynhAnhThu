namespace Lab03_Bai01
{
    partial class UDPServer
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
            button_listen = new Button();
            textBox_rcvport = new TextBox();
            richTextBox_rcvmessage = new RichTextBox();
            SuspendLayout();
            // 
            // button_listen
            // 
            button_listen.Location = new Point(598, 65);
            button_listen.Name = "button_listen";
            button_listen.Size = new Size(97, 30);
            button_listen.TabIndex = 1;
            button_listen.Text = "Listen";
            button_listen.UseVisualStyleBackColor = true;
            button_listen.Click += button_listen_Click;
            // 
            // textBox_rcvport
            // 
            textBox_rcvport.Location = new Point(99, 68);
            textBox_rcvport.Name = "textBox_rcvport";
            textBox_rcvport.ReadOnly = true;
            textBox_rcvport.Size = new Size(134, 27);
            textBox_rcvport.TabIndex = 2;
            // 
            // richTextBox_rcvmessage
            // 
            richTextBox_rcvmessage.Location = new Point(107, 193);
            richTextBox_rcvmessage.Name = "richTextBox_rcvmessage";
            richTextBox_rcvmessage.Size = new Size(588, 217);
            richTextBox_rcvmessage.TabIndex = 3;
            richTextBox_rcvmessage.Text = "";
            // 
            // UDPServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_rcvmessage);
            Controls.Add(textBox_rcvport);
            Controls.Add(button_listen);
            Name = "UDPServer";
            Text = "UDPServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_listen;
        private TextBox textBox_rcvport;
        private RichTextBox richTextBox_rcvmessage;
    }
}