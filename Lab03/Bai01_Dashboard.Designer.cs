namespace Lab03_Bai01
{
    partial class Bai01_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai01_Dashboard));
            button_server = new Button();
            button_client = new Button();
            SuspendLayout();
            // 
            // button_server
            // 
            button_server.BackColor = Color.Transparent;
            button_server.FlatAppearance.BorderSize = 0;
            button_server.FlatStyle = FlatStyle.Flat;
            button_server.Location = new Point(62, 363);
            button_server.Name = "button_server";
            button_server.Size = new Size(175, 52);
            button_server.TabIndex = 0;
            button_server.UseVisualStyleBackColor = false;
            button_server.Click += button_server_Click;
            // 
            // button_client
            // 
            button_client.BackColor = Color.Transparent;
            button_client.BackgroundImageLayout = ImageLayout.None;
            button_client.FlatAppearance.BorderSize = 0;
            button_client.FlatStyle = FlatStyle.Flat;
            button_client.Location = new Point(164, 254);
            button_client.Name = "button_client";
            button_client.Size = new Size(199, 44);
            button_client.TabIndex = 1;
            button_client.UseVisualStyleBackColor = false;
            button_client.Click += button_client_Click;
            // 
            // Bai01_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button_server);
            Controls.Add(button_client);
            Name = "Bai01_Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button button_server;
        private Button button_client;
    }
}