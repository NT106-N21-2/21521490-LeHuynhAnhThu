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
            button_write = new Button();
            button_read = new Button();
            richTextBox_input = new RichTextBox();
            richTextBox_output = new RichTextBox();
            SuspendLayout();
            // 
            // button_write
            // 
            button_write.Location = new Point(582, 40);
            button_write.Name = "button_write";
            button_write.Size = new Size(153, 68);
            button_write.TabIndex = 0;
            button_write.Text = "GHI FILE";
            button_write.UseVisualStyleBackColor = true;
            button_write.Click += button_write_Click;
            // 
            // button_read
            // 
            button_read.Location = new Point(92, 40);
            button_read.Name = "button_read";
            button_read.Size = new Size(153, 68);
            button_read.TabIndex = 1;
            button_read.Text = "ĐỌC FILE";
            button_read.UseVisualStyleBackColor = true;
            button_read.Click += button_read_Click;
            // 
            // richTextBox_input
            // 
            richTextBox_input.Location = new Point(38, 147);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(252, 272);
            richTextBox_input.TabIndex = 2;
            richTextBox_input.Text = "";
            // 
            // richTextBox_output
            // 
            richTextBox_output.Location = new Point(527, 147);
            richTextBox_output.Name = "richTextBox_output";
            richTextBox_output.Size = new Size(252, 272);
            richTextBox_output.TabIndex = 3;
            richTextBox_output.Text = "";
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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