namespace Lab03_Bai01
{
    partial class Bai01_UDPServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai01_UDPServer));
            button_listen = new Button();
            textBox_rcvport = new TextBox();
            richTextBox_rcvmessage = new RichTextBox();
            SuspendLayout();
            // 
            // button_listen
            // 
            button_listen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_listen.Location = new Point(601, 94);
            button_listen.Name = "button_listen";
            button_listen.Size = new Size(110, 30);
            button_listen.TabIndex = 1;
            button_listen.Text = "Listen";
            button_listen.UseVisualStyleBackColor = true;
            button_listen.Click += button_listen_Click;
            // 
            // textBox_rcvport
            // 
            textBox_rcvport.BorderStyle = BorderStyle.None;
            textBox_rcvport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_rcvport.Location = new Point(123, 94);
            textBox_rcvport.Name = "textBox_rcvport";
            textBox_rcvport.ReadOnly = true;
            textBox_rcvport.Size = new Size(160, 20);
            textBox_rcvport.TabIndex = 2;
            // 
            // richTextBox_rcvmessage
            // 
            richTextBox_rcvmessage.BorderStyle = BorderStyle.None;
            richTextBox_rcvmessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_rcvmessage.Location = new Point(123, 221);
            richTextBox_rcvmessage.Name = "richTextBox_rcvmessage";
            richTextBox_rcvmessage.Size = new Size(588, 135);
            richTextBox_rcvmessage.TabIndex = 3;
            richTextBox_rcvmessage.Text = "";
            // 
            // Bai01_UDPServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_rcvmessage);
            Controls.Add(textBox_rcvport);
            Controls.Add(button_listen);
            Name = "Bai01_UDPServer";
            Text = "UDPServer";
            Load += Bai01_UDPServer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_listen;
        private TextBox textBox_rcvport;
        private RichTextBox richTextBox_rcvmessage;
    }
}