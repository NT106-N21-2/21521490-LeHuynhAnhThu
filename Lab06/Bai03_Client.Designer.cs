namespace Lab06
{
    partial class Bai03_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai03_Client));
            textBox_name = new TextBox();
            richTextBox_chat = new RichTextBox();
            button_send = new Button();
            textBox_message = new TextBox();
            SuspendLayout();
            // 
            // textBox_name
            // 
            textBox_name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_name.ForeColor = Color.FromArgb(105, 0, 97);
            textBox_name.Location = new Point(176, 156);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(150, 27);
            textBox_name.TabIndex = 3;
            // 
            // richTextBox_chat
            // 
            richTextBox_chat.BackColor = Color.FromArgb(240, 193, 241);
            richTextBox_chat.BorderStyle = BorderStyle.None;
            richTextBox_chat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_chat.ForeColor = Color.FromArgb(105, 0, 97);
            richTextBox_chat.Location = new Point(383, 134);
            richTextBox_chat.Name = "richTextBox_chat";
            richTextBox_chat.Size = new Size(361, 254);
            richTextBox_chat.TabIndex = 6;
            richTextBox_chat.Text = "\n";
            // 
            // button_send
            // 
            button_send.BackColor = Color.Transparent;
            button_send.FlatAppearance.BorderSize = 0;
            button_send.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_send.FlatStyle = FlatStyle.Flat;
            button_send.Location = new Point(90, 255);
            button_send.Name = "button_send";
            button_send.Size = new Size(218, 36);
            button_send.TabIndex = 5;
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click_1;
            // 
            // textBox_message
            // 
            textBox_message.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_message.ForeColor = Color.FromArgb(105, 0, 97);
            textBox_message.Location = new Point(175, 199);
            textBox_message.Name = "textBox_message";
            textBox_message.Size = new Size(162, 27);
            textBox_message.TabIndex = 4;
            // 
            // Bai03_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_name);
            Controls.Add(richTextBox_chat);
            Controls.Add(button_send);
            Controls.Add(textBox_message);
            Name = "Bai03_Client";
            Text = "Lab06_Bai03";
            FormClosing += ClientForm_FormClosing;
            Load += Bai03_Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_name;
        private RichTextBox richTextBox_chat;
        private Button button_send;
        private TextBox textBox_message;
    }
}