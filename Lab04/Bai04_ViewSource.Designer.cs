namespace Lab04
{
    partial class Bai04_ViewSource
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
            richTextBox_source = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox_source
            // 
            richTextBox_source.Location = new Point(12, 12);
            richTextBox_source.Name = "richTextBox_source";
            richTextBox_source.Size = new Size(776, 426);
            richTextBox_source.TabIndex = 0;
            richTextBox_source.Text = "";
            // 
            // Bai04_ViewSource
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_source);
            Name = "Bai04_ViewSource";
            Text = "Bai04_ViewSource";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_source;
    }
}