namespace Lab06
{
    partial class Lab06_Bai02
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
            richTextBox_decode = new RichTextBox();
            richTextBox_encode = new RichTextBox();
            richTextBox_input = new RichTextBox();
            textBox_key = new TextBox();
            button_decode = new Button();
            button_encode = new Button();
            SuspendLayout();
            // 
            // richTextBox_decode
            // 
            richTextBox_decode.Location = new Point(29, 345);
            richTextBox_decode.Name = "richTextBox_decode";
            richTextBox_decode.ReadOnly = true;
            richTextBox_decode.Size = new Size(743, 78);
            richTextBox_decode.TabIndex = 11;
            richTextBox_decode.Text = "";
            // 
            // richTextBox_encode
            // 
            richTextBox_encode.Location = new Point(29, 236);
            richTextBox_encode.Name = "richTextBox_encode";
            richTextBox_encode.ReadOnly = true;
            richTextBox_encode.Size = new Size(743, 78);
            richTextBox_encode.TabIndex = 10;
            richTextBox_encode.Text = "";
            // 
            // richTextBox_input
            // 
            richTextBox_input.Location = new Point(29, 130);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(743, 78);
            richTextBox_input.TabIndex = 9;
            richTextBox_input.Text = "";
            // 
            // textBox_key
            // 
            textBox_key.Location = new Point(29, 65);
            textBox_key.Name = "textBox_key";
            textBox_key.Size = new Size(125, 27);
            textBox_key.TabIndex = 8;
            // 
            // button_decode
            // 
            button_decode.Location = new Point(678, 28);
            button_decode.Name = "button_decode";
            button_decode.Size = new Size(94, 29);
            button_decode.TabIndex = 7;
            button_decode.Text = "GIẢI MÃ";
            button_decode.UseVisualStyleBackColor = true;
            button_decode.Click += button_decode_Click;
            // 
            // button_encode
            // 
            button_encode.Location = new Point(537, 28);
            button_encode.Name = "button_encode";
            button_encode.Size = new Size(94, 29);
            button_encode.TabIndex = 6;
            button_encode.Text = "MÃ HÓA";
            button_encode.UseVisualStyleBackColor = true;
            button_encode.Click += button_encode_Click;
            // 
            // Lab06_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_decode);
            Controls.Add(richTextBox_encode);
            Controls.Add(richTextBox_input);
            Controls.Add(textBox_key);
            Controls.Add(button_decode);
            Controls.Add(button_encode);
            Name = "Lab06_Bai02";
            Text = "Lab06_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_decode;
        private RichTextBox richTextBox_encode;
        private RichTextBox richTextBox_input;
        private TextBox textBox_key;
        private Button button_decode;
        private Button button_encode;
    }
}