namespace Lab04
{
    partial class Lab04_Bai01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab04_Bai01));
            button1 = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(557, 81);
            button1.Name = "button1";
            button1.Size = new Size(175, 29);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += get_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightPink;
            textBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(57, 77);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 38);
            textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Pink;
            richTextBox1.Location = new Point(57, 148);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(675, 228);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Lab04_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Lab04_Bai01";
            Text = "Lab04_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
    }
}