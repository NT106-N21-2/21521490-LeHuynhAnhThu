namespace Lab03_Bai05
{
    partial class ServerForm
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
            richTextBox_server = new RichTextBox();
            SuspendLayout();
            // 
            // button_listen
            // 
            button_listen.Location = new Point(605, 64);
            button_listen.Name = "button_listen";
            button_listen.Size = new Size(94, 29);
            button_listen.TabIndex = 0;
            button_listen.Text = "Listen";
            button_listen.UseVisualStyleBackColor = true;
            button_listen.Click += button_listen_Click;
            // 
            // richTextBox_server
            // 
            richTextBox_server.Location = new Point(76, 126);
            richTextBox_server.Name = "richTextBox_server";
            richTextBox_server.Size = new Size(649, 282);
            richTextBox_server.TabIndex = 3;
            richTextBox_server.Text = "";
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_server);
            Controls.Add(button_listen);
            Name = "ServerForm";
            Text = "ServerForm";
            FormClosing += ServerForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button button_listen;
        private RichTextBox richTextBox_server;
    }
}