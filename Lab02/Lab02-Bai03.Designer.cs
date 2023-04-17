namespace Lab02
{
    partial class Lab02_Bai03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab02_Bai03));
            richTextBox_output = new RichTextBox();
            richTextBox_input = new RichTextBox();
            button_read = new Button();
            button_write = new Button();
            SuspendLayout();
            // 
            // richTextBox_output
            // 
            richTextBox_output.BackColor = Color.FromArgb(255, 215, 218);
            richTextBox_output.BorderStyle = BorderStyle.None;
            richTextBox_output.Location = new Point(575, 256);
            richTextBox_output.Name = "richTextBox_output";
            richTextBox_output.Size = new Size(364, 255);
            richTextBox_output.TabIndex = 7;
            richTextBox_output.Text = "";
            // 
            // richTextBox_input
            // 
            richTextBox_input.BackColor = Color.FromArgb(255, 215, 218);
            richTextBox_input.BorderStyle = BorderStyle.None;
            richTextBox_input.Location = new Point(25, 255);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(363, 255);
            richTextBox_input.TabIndex = 6;
            richTextBox_input.Text = "";
            // 
            // button_read
            // 
            button_read.BackColor = Color.FromArgb(255, 230, 210);
            button_read.FlatStyle = FlatStyle.Flat;
            button_read.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_read.Location = new Point(410, 298);
            button_read.Name = "button_read";
            button_read.Size = new Size(141, 68);
            button_read.TabIndex = 5;
            button_read.Text = "ĐỌC FILE";
            button_read.UseVisualStyleBackColor = false;
            button_read.Click += button_read_Click;
            // 
            // button_write
            // 
            button_write.BackColor = Color.FromArgb(242, 182, 187);
            button_write.FlatStyle = FlatStyle.Flat;
            button_write.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_write.Location = new Point(407, 393);
            button_write.Name = "button_write";
            button_write.Size = new Size(145, 68);
            button_write.TabIndex = 4;
            button_write.Text = "GHI FILE";
            button_write.UseVisualStyleBackColor = false;
            button_write.Click += button_write_Click;
            // 
            // Lab02_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(961, 539);
            Controls.Add(richTextBox_output);
            Controls.Add(richTextBox_input);
            Controls.Add(button_read);
            Controls.Add(button_write);
            Name = "Lab02_Bai03";
            Text = "Lab02_Bai03";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_output;
        private RichTextBox richTextBox_input;
        private Button button_read;
        private Button button_write;
    }
}