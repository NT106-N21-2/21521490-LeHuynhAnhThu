namespace Lab03_Bai04
{
    partial class Server2
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
            richTextBox2 = new RichTextBox();
            Listen = new Button();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(118, 204);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(421, 165);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // Listen
            // 
            Listen.Location = new Point(115, 44);
            Listen.Name = "Listen";
            Listen.Size = new Size(94, 29);
            Listen.TabIndex = 2;
            Listen.Text = "Listen";
            Listen.UseVisualStyleBackColor = true;
            Listen.Click += Listen_Click;
            // 
            // Server2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Listen);
            Controls.Add(richTextBox2);
            Name = "Server2";
            Text = "Server2";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox2;
        private Button Listen;
    }
}