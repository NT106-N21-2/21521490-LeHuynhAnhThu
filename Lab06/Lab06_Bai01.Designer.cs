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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab06_Bai01));
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
            button_encode.BackColor = Color.Transparent;
            button_encode.FlatAppearance.BorderSize = 0;
            button_encode.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_encode.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_encode.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_encode.FlatStyle = FlatStyle.Flat;
            button_encode.Location = new Point(116, 189);
            button_encode.Name = "button_encode";
            button_encode.Size = new Size(120, 29);
            button_encode.TabIndex = 0;
            button_encode.UseVisualStyleBackColor = false;
            button_encode.Click += button_encode_Click;
            // 
            // button_decode
            // 
            button_decode.BackColor = Color.Transparent;
            button_decode.FlatAppearance.BorderSize = 0;
            button_decode.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_decode.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_decode.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_decode.FlatStyle = FlatStyle.Flat;
            button_decode.Location = new Point(116, 244);
            button_decode.Name = "button_decode";
            button_decode.Size = new Size(120, 29);
            button_decode.TabIndex = 1;
            button_decode.UseVisualStyleBackColor = false;
            button_decode.Click += button_decode_Click;
            // 
            // textBox_shift
            // 
            textBox_shift.BackColor = Color.FromArgb(240, 193, 241);
            textBox_shift.BorderStyle = BorderStyle.None;
            textBox_shift.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_shift.ForeColor = Color.FromArgb(105, 0, 97);
            textBox_shift.Location = new Point(114, 141);
            textBox_shift.Name = "textBox_shift";
            textBox_shift.Size = new Size(125, 16);
            textBox_shift.TabIndex = 2;
            // 
            // richTextBox_input
            // 
            richTextBox_input.BackColor = Color.White;
            richTextBox_input.BorderStyle = BorderStyle.None;
            richTextBox_input.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_input.ForeColor = Color.FromArgb(105, 0, 97);
            richTextBox_input.Location = new Point(383, 90);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(381, 89);
            richTextBox_input.TabIndex = 3;
            richTextBox_input.Text = "";
            // 
            // richTextBox_encode
            // 
            richTextBox_encode.BackColor = Color.White;
            richTextBox_encode.BorderStyle = BorderStyle.None;
            richTextBox_encode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_encode.ForeColor = Color.FromArgb(105, 0, 97);
            richTextBox_encode.Location = new Point(383, 212);
            richTextBox_encode.Name = "richTextBox_encode";
            richTextBox_encode.ReadOnly = true;
            richTextBox_encode.Size = new Size(381, 94);
            richTextBox_encode.TabIndex = 4;
            richTextBox_encode.Text = "";
            // 
            // richTextBox_decode
            // 
            richTextBox_decode.BackColor = Color.White;
            richTextBox_decode.BorderStyle = BorderStyle.None;
            richTextBox_decode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_decode.ForeColor = Color.FromArgb(105, 0, 97);
            richTextBox_decode.Location = new Point(383, 341);
            richTextBox_decode.Name = "richTextBox_decode";
            richTextBox_decode.ReadOnly = true;
            richTextBox_decode.Size = new Size(375, 69);
            richTextBox_decode.TabIndex = 5;
            richTextBox_decode.Text = "";
            // 
            // Lab06_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 466);
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