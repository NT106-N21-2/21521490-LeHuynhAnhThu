﻿namespace Lab01
{
    partial class Lab01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(252, 248, 241);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(528, 85);
            button1.Name = "button1";
            button1.Size = new Size(281, 47);
            button1.TabIndex = 0;
            button1.Text = "BÀI 01";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(252, 248, 241);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(528, 136);
            button2.Name = "button2";
            button2.Size = new Size(281, 47);
            button2.TabIndex = 1;
            button2.Text = "BÀI 02";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(252, 248, 241);
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(528, 187);
            button3.Name = "button3";
            button3.Size = new Size(281, 47);
            button3.TabIndex = 2;
            button3.Text = "BÀI 03";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(252, 248, 241);
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(528, 237);
            button4.Name = "button4";
            button4.Size = new Size(281, 47);
            button4.TabIndex = 3;
            button4.Text = "BÀI 04";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Lab01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 519);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lab01";
            Text = "Lab01";
            Load += Lab01_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}