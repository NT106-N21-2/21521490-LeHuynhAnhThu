﻿namespace Lab03
{
    partial class Bai04_Server2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04_Server2));
            richTextBox1 = new RichTextBox();
            button_listen = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(150, 199);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(537, 176);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button_listen
            // 
            button_listen.BackColor = Color.Transparent;
            button_listen.FlatStyle = FlatStyle.Flat;
            button_listen.Location = new Point(333, 408);
            button_listen.Name = "button_listen";
            button_listen.Size = new Size(130, 42);
            button_listen.TabIndex = 6;
            button_listen.UseVisualStyleBackColor = false;
            button_listen.Click += button_listen_Click;
            // 
            // Bai04_Server2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 470);
            Controls.Add(button_listen);
            Controls.Add(richTextBox1);
            Name = "Bai04_Server2";
            Text = "Bai04_Server2";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_listen;
    }
}