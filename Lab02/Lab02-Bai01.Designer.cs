namespace Lab02
{
    partial class Lab02_Bai01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab02_Bai01));
            button_write = new Button();
            button_read = new Button();
            richTextBox_input = new RichTextBox();
            richTextBox_output = new RichTextBox();
            SuspendLayout();
            // 
            // button_write
            // 
            button_write.BackColor = Color.FromArgb(255, 230, 210);
            button_write.FlatStyle = FlatStyle.Flat;
            button_write.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_write.Location = new Point(407, 393);
            button_write.Name = "button_write";
            button_write.Size = new Size(142, 68);
            button_write.TabIndex = 0;
            button_write.Text = "GHI FILE";
            button_write.UseVisualStyleBackColor = false;
            button_write.Click += button_write_Click;
            // 
            // button_read
            // 
            button_read.BackColor = Color.FromArgb(242, 182, 187);
            button_read.FlatStyle = FlatStyle.Flat;
            button_read.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_read.Location = new Point(410, 291);
            button_read.Name = "button_read";
            button_read.Size = new Size(142, 74);
            button_read.TabIndex = 1;
            button_read.Text = "ĐỌC FILE";
            button_read.UseVisualStyleBackColor = false;
            button_read.Click += button_read_Click;
            // 
            // richTextBox_input
            // 
            richTextBox_input.BackColor = Color.FromArgb(253, 213, 216);
            richTextBox_input.BorderStyle = BorderStyle.None;
            richTextBox_input.Location = new Point(26, 258);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.ReadOnly = true;
            richTextBox_input.Size = new Size(360, 253);
            richTextBox_input.TabIndex = 2;
            richTextBox_input.Text = "";
            // 
            // richTextBox_output
            // 
            richTextBox_output.BackColor = Color.FromArgb(253, 213, 216);
            richTextBox_output.BorderStyle = BorderStyle.None;
            richTextBox_output.Location = new Point(573, 258);
            richTextBox_output.Name = "richTextBox_output";
            richTextBox_output.ReadOnly = true;
            richTextBox_output.Size = new Size(364, 253);
            richTextBox_output.TabIndex = 3;
            richTextBox_output.Text = "";
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(961, 539);
            Controls.Add(richTextBox_output);
            Controls.Add(richTextBox_input);
            Controls.Add(button_read);
            Controls.Add(button_write);
            Name = "Lab02_Bai01";
            Text = "Lab02_Bai01";
            ResumeLayout(false);
        }

        #endregion

        private Button button_write;
        private Button button_read;
        private RichTextBox richTextBox_input;
        private RichTextBox richTextBox_output;
    }
}