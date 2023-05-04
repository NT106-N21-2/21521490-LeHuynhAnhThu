namespace Lab03_Bai05
{
    partial class Bai05_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai05_Dashboard));
            button_client = new Button();
            button_server = new Button();
            SuspendLayout();
            // 
            // button_client
            // 
            button_client.BackColor = Color.Transparent;
            button_client.FlatAppearance.BorderSize = 0;
            button_client.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_client.FlatStyle = FlatStyle.Flat;
            button_client.Location = new Point(82, 179);
            button_client.Name = "button_client";
            button_client.Size = new Size(198, 178);
            button_client.TabIndex = 3;
            button_client.UseVisualStyleBackColor = false;
            button_client.Click += button_client_Click;
            // 
            // button_server
            // 
            button_server.BackColor = Color.Transparent;
            button_server.FlatAppearance.BorderSize = 0;
            button_server.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_server.FlatStyle = FlatStyle.Flat;
            button_server.Location = new Point(552, 179);
            button_server.Name = "button_server";
            button_server.Size = new Size(188, 178);
            button_server.TabIndex = 2;
            button_server.UseVisualStyleBackColor = false;
            button_server.Click += button_server_Click;
            // 
            // Bai05_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 485);
            Controls.Add(button_client);
            Controls.Add(button_server);
            Name = "Bai05_Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button button_client;
        private Button button_server;
    }
}