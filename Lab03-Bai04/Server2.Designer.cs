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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Listen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(118, 204);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(421, 165);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // Listen
            // 
            this.Listen.Location = new System.Drawing.Point(115, 44);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(94, 29);
            this.Listen.TabIndex = 2;
            this.Listen.Text = "Listen";
            this.Listen.UseVisualStyleBackColor = true;
            this.Listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // Server2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listen);
            this.Controls.Add(this.richTextBox2);
            this.Name = "Server2";
            this.Text = "Server2";
            this.Load += new System.EventHandler(this.Server2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox2;
        private Button Listen;
    }
}