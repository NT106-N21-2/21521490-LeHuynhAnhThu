﻿namespace Lab02
{
    partial class Lab02_Bai06
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
            treeView_folder = new TreeView();
            richTextBox_file = new RichTextBox();
            pictureBox_file = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_file).BeginInit();
            SuspendLayout();
            // 
            // treeView_folder
            // 
            treeView_folder.Location = new Point(13, 10);
            treeView_folder.Name = "treeView_folder";
            treeView_folder.Size = new Size(204, 426);
            treeView_folder.TabIndex = 0;
            treeView_folder.NodeMouseClick += treeView_folder_NodeMouseClick;
            treeView_folder.NodeMouseDoubleClick += treeView_folder_NodeMouseDoubleClick;
            // 
            // richTextBox_file
            // 
            richTextBox_file.Location = new Point(581, 78);
            richTextBox_file.Name = "richTextBox_file";
            richTextBox_file.ReadOnly = true;
            richTextBox_file.Size = new Size(207, 358);
            richTextBox_file.TabIndex = 1;
            richTextBox_file.Text = "";
            // 
            // pictureBox_file
            // 
            pictureBox_file.BackColor = Color.Transparent;
            pictureBox_file.Location = new Point(223, 78);
            pictureBox_file.Name = "pictureBox_file";
            pictureBox_file.Size = new Size(352, 358);
            pictureBox_file.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_file.TabIndex = 2;
            pictureBox_file.TabStop = false;
            // 
            // Lab02_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox_file);
            Controls.Add(richTextBox_file);
            Controls.Add(treeView_folder);
            Name = "Lab02_Bai06";
            Text = "Lab02_Bai06";
            ((System.ComponentModel.ISupportInitialize)pictureBox_file).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView_folder;
        private RichTextBox richTextBox_file;
        private PictureBox pictureBox_file;
    }
}