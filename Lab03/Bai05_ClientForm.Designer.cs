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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai05_ClientForm));
            textBox_message = new TextBox();
            button_send = new Button();
            richTextBox_chat = new RichTextBox();
            textBox_name = new TextBox();
            SuspendLayout();
            // 
            // textBox_message
            // 
            textBox_message.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_message.Location = new Point(447, 358);
            textBox_message.Name = "textBox_message";
            textBox_message.Size = new Size(260, 27);
            textBox_message.TabIndex = 0;
            textBox_message.TextChanged += textBox_message_TextChanged;
            // 
            // button_send
            // 
            button_send.BackColor = Color.Transparent;
            button_send.FlatAppearance.BorderSize = 0;
            button_send.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_send.FlatStyle = FlatStyle.Flat;
            button_send.Location = new Point(511, 415);
            button_send.Name = "button_send";
            button_send.Size = new Size(90, 55);
            button_send.TabIndex = 1;
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // richTextBox_chat
            // 
            richTextBox_chat.BorderStyle = BorderStyle.None;
            richTextBox_chat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_chat.Location = new Point(326, 120);
            richTextBox_chat.Name = "richTextBox_chat";
            richTextBox_chat.Size = new Size(422, 126);
            richTextBox_chat.TabIndex = 2;
            richTextBox_chat.Text = "";
            // 
            // textBox_name
            // 
            textBox_name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_name.Location = new Point(451, 297);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(150, 27);
            textBox_name.TabIndex = 0;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // Bai05_ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 481);
            Controls.Add(textBox_name);
            Controls.Add(richTextBox_chat);
            Controls.Add(button_send);
            Controls.Add(textBox_message);
            Name = "Bai05_ClientForm";
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