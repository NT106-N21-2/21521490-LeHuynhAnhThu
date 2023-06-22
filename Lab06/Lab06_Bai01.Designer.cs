namespace Lab06
{
    partial class Lab06_Bai01
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
            button_encode = new Button();
            button_decode = new Button();
            textBox_shift = new TextBox();
            richTextBox_input = new RichTextBox();
            richTextBox_encode = new RichTextBox();
            richTextBox_decode = new RichTextBox();
            SuspendLayout();
            // 
            // button_encode
            // 
            button_encode.Location = new Point(541, 26);
            button_encode.Name = "button_encode";
            button_encode.Size = new Size(94, 29);
            button_encode.TabIndex = 0;
            button_encode.Text = "MÃ HÓA";
            button_encode.UseVisualStyleBackColor = true;
            button_encode.Click += button_encode_Click;
            // 
            // button_decode
            // 
            button_decode.Location = new Point(682, 26);
            button_decode.Name = "button_decode";
            button_decode.Size = new Size(94, 29);
            button_decode.TabIndex = 1;
            button_decode.Text = "GIẢI MÃ";
            button_decode.UseVisualStyleBackColor = true;
            button_decode.Click += button_decode_Click;
            // 
            // textBox_shift
            // 
            textBox_shift.Location = new Point(33, 63);
            textBox_shift.Name = "textBox_shift";
            textBox_shift.Size = new Size(125, 27);
            textBox_shift.TabIndex = 2;
            // 
            // richTextBox_input
            // 
            richTextBox_input.Location = new Point(33, 128);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(743, 78);
            richTextBox_input.TabIndex = 3;
            richTextBox_input.Text = "";
            // 
            // richTextBox_encode
            // 
            richTextBox_encode.Location = new Point(33, 234);
            richTextBox_encode.Name = "richTextBox_encode";
            richTextBox_encode.ReadOnly = true;
            richTextBox_encode.Size = new Size(743, 78);
            richTextBox_encode.TabIndex = 4;
            richTextBox_encode.Text = "";
            // 
            // richTextBox_decode
            // 
            richTextBox_decode.Location = new Point(33, 343);
            richTextBox_decode.Name = "richTextBox_decode";
            richTextBox_decode.ReadOnly = true;
            richTextBox_decode.Size = new Size(743, 78);
            richTextBox_decode.TabIndex = 5;
            richTextBox_decode.Text = "";
            // 
            // Lab06_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_decode);
            Controls.Add(richTextBox_encode);
            Controls.Add(richTextBox_input);
            Controls.Add(textBox_shift);
            Controls.Add(button_decode);
            Controls.Add(button_encode);
            Name = "Lab06_Bai01";
            Text = "Lab06_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_encode;
        private Button button_decode;
        private TextBox textBox_shift;
        private RichTextBox richTextBox_input;
        private RichTextBox richTextBox_encode;
        private RichTextBox richTextBox_decode;
    }
}