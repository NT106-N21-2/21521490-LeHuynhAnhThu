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
            richTextBox_output = new RichTextBox();
            richTextBox_input = new RichTextBox();
            button_read = new Button();
            button_write = new Button();
            SuspendLayout();
            // 
            // richTextBox_output
            // 
            richTextBox_output.Location = new Point(519, 149);
            richTextBox_output.Name = "richTextBox_output";
            richTextBox_output.Size = new Size(252, 272);
            richTextBox_output.TabIndex = 7;
            richTextBox_output.Text = "";
            // 
            // richTextBox_input
            // 
            richTextBox_input.Location = new Point(30, 149);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(252, 272);
            richTextBox_input.TabIndex = 6;
            richTextBox_input.Text = "";
            // 
            // button_read
            // 
            button_read.Location = new Point(85, 29);
            button_read.Name = "button_read";
            button_read.Size = new Size(153, 68);
            button_read.TabIndex = 5;
            button_read.Text = "ĐỌC FILE";
            button_read.UseVisualStyleBackColor = true;
            button_read.Click += button_read_Click;
            // 
            // button_write
            // 
            button_write.Location = new Point(571, 29);
            button_write.Name = "button_write";
            button_write.Size = new Size(153, 68);
            button_write.TabIndex = 4;
            button_write.Text = "GHI FILE";
            button_write.UseVisualStyleBackColor = true;
            button_write.Click += button_write_Click;
            // 
            // Lab02_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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