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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04_Client));
            richTextBox1 = new RichTextBox();
            button_disconnect = new Button();
            button_send = new Button();
            button_connect = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(177, 187);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(466, 162);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button_disconnect
            // 
            button_disconnect.BackColor = Color.Transparent;
            button_disconnect.FlatAppearance.BorderSize = 0;
            button_disconnect.FlatStyle = FlatStyle.Flat;
            button_disconnect.Location = new Point(509, 348);
            button_disconnect.Name = "button_disconnect";
            button_disconnect.Size = new Size(117, 41);
            button_disconnect.TabIndex = 6;
            button_disconnect.UseVisualStyleBackColor = false;
            button_disconnect.Click += button_disconnect_Click;
            // 
            // button_send
            // 
            button_send.BackColor = Color.Transparent;
            button_send.FlatAppearance.BorderSize = 0;
            button_send.FlatStyle = FlatStyle.Flat;
            button_send.Location = new Point(376, 348);
            button_send.Name = "button_send";
            button_send.Size = new Size(116, 39);
            button_send.TabIndex = 5;
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // button_connect
            // 
            button_connect.BackColor = Color.Transparent;
            button_connect.FlatAppearance.BorderSize = 0;
            button_connect.FlatStyle = FlatStyle.Flat;
            button_connect.Location = new Point(236, 348);
            button_connect.Name = "button_connect";
            button_connect.Size = new Size(117, 39);
            button_connect.TabIndex = 4;
            button_connect.UseVisualStyleBackColor = false;
            button_connect.Click += button_connect_Click;
            // 
            // Bai04_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(819, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button_disconnect);
            Controls.Add(button_send);
            Controls.Add(button_connect);
            Name = "Bai04_Client";
            Text = "Bai04_Client";
            Load += Bai04_Client_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_disconnect;
        private Button button_send;
        private Button button_connect;
    }
}