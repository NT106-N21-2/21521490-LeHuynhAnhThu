namespace Lab03_Bai05
{
    partial class Bai05_ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai05_ServerForm));
            button_listen = new Button();
            richTextBox_server = new RichTextBox();
            SuspendLayout();
            // 
            // button_listen
            // 
            button_listen.BackColor = Color.Transparent;
            button_listen.FlatAppearance.BorderSize = 0;
            button_listen.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_listen.FlatStyle = FlatStyle.Flat;
            button_listen.Location = new Point(95, 337);
            button_listen.Name = "button_listen";
            button_listen.Size = new Size(123, 47);
            button_listen.TabIndex = 0;
            button_listen.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_listen.UseVisualStyleBackColor = false;
            button_listen.Click += button_listen_Click;
            // 
            // richTextBox_server
            // 
            richTextBox_server.BorderStyle = BorderStyle.None;
            richTextBox_server.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_server.Location = new Point(330, 120);
            richTextBox_server.Name = "richTextBox_server";
            richTextBox_server.Size = new Size(411, 264);
            richTextBox_server.TabIndex = 3;
            richTextBox_server.Text = "";
            // 
            // Bai05_ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 440);
            Controls.Add(richTextBox_server);
            Controls.Add(button_listen);
            Name = "Bai05_ServerForm";
            Text = "ServerForm";
            FormClosing += ServerForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button button_listen;
        private RichTextBox richTextBox_server;
    }
}