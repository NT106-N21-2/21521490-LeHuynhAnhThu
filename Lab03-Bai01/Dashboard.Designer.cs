﻿namespace Lab03_Bai01
{
    partial class Dashboard
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
            button_server = new Button();
            button_client = new Button();
            SuspendLayout();
            // 
            // button_server
            // 
            button_server.Location = new Point(81, 151);
            button_server.Name = "button_server";
            button_server.Size = new Size(175, 44);
            button_server.TabIndex = 0;
            button_server.Text = "UDP Server";
            button_server.UseVisualStyleBackColor = true;
            button_server.Click += button_server_Click;
            // 
            // button_client
            // 
            button_client.Location = new Point(554, 151);
            button_client.Name = "button_client";
            button_client.Size = new Size(175, 44);
            button_client.TabIndex = 1;
            button_client.Text = "UDP Client";
            button_client.UseVisualStyleBackColor = true;
            button_client.Click += button_client_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_client);
            Controls.Add(button_server);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button button_server;
        private Button button_client;
    }
}