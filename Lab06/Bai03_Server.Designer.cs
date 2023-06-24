namespace Lab06
{
    partial class Bai03_Server
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
            richTextBox_server = new RichTextBox();
            button_listen = new Button();
            SuspendLayout();
            // 
            // richTextBox_server
            // 
            richTextBox_server.BackColor = SystemColors.ActiveCaption;
            richTextBox_server.BorderStyle = BorderStyle.None;
            richTextBox_server.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_server.Location = new Point(312, 93);
            richTextBox_server.Name = "richTextBox_server";
            richTextBox_server.Size = new Size(411, 264);
            richTextBox_server.TabIndex = 5;
            richTextBox_server.Text = "";
            // 
            // button_listen
            // 
            button_listen.BackColor = SystemColors.ActiveCaption;
            button_listen.FlatAppearance.BorderSize = 0;
            button_listen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_listen.FlatStyle = FlatStyle.Flat;
            button_listen.Location = new Point(77, 310);
            button_listen.Name = "button_listen";
            button_listen.Size = new Size(123, 47);
            button_listen.TabIndex = 4;
            button_listen.Text = "listen";
            button_listen.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_listen.UseVisualStyleBackColor = false;
            button_listen.Click += button_listen_Click_1;
            // 
            // Bai03_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_server);
            Controls.Add(button_listen);
            Name = "Bai03_Server";
            Text = "Bai03_Server";
            FormClosing += ServerForm_FormClosing;
           
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_server;
        private Button button_listen;
    }
}