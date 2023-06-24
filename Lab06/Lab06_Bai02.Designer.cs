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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab06_Bai02));
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
            richTextBox_decode.BackColor = Color.White;
            richTextBox_decode.BorderStyle = BorderStyle.None;
            richTextBox_decode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_decode.ForeColor = Color.FromArgb(105, 0, 97);
            richTextBox_decode.Location = new Point(373, 336);
            richTextBox_decode.Name = "richTextBox_decode";
            richTextBox_decode.ReadOnly = true;
            richTextBox_decode.Size = new Size(385, 78);
            richTextBox_decode.TabIndex = 11;
            richTextBox_decode.Text = "";
            // 
            // richTextBox_encode
            // 
            richTextBox_encode.BackColor = Color.White;
            richTextBox_encode.BorderStyle = BorderStyle.None;
            richTextBox_encode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_encode.ForeColor = Color.FromArgb(105, 0, 97);
            richTextBox_encode.Location = new Point(373, 211);
            richTextBox_encode.Name = "richTextBox_encode";
            richTextBox_encode.ReadOnly = true;
            richTextBox_encode.Size = new Size(385, 93);
            richTextBox_encode.TabIndex = 10;
            richTextBox_encode.Text = "";
            // 
            // richTextBox_input
            // 
            richTextBox_input.BackColor = Color.White;
            richTextBox_input.BorderStyle = BorderStyle.None;
            richTextBox_input.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_input.ForeColor = Color.FromArgb(105, 0, 97);
            richTextBox_input.Location = new Point(373, 97);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(385, 78);
            richTextBox_input.TabIndex = 9;
            richTextBox_input.Text = "";
            // 
            // textBox_key
            // 
            textBox_key.BackColor = Color.FromArgb(240, 193, 241);
            textBox_key.BorderStyle = BorderStyle.None;
            textBox_key.ForeColor = Color.FromArgb(105, 0, 97);
            textBox_key.Location = new Point(114, 140);
            textBox_key.Name = "textBox_key";
            textBox_key.Size = new Size(125, 20);
            textBox_key.TabIndex = 8;
            // 
            // button_decode
            // 
            button_decode.BackColor = Color.Transparent;
            button_decode.FlatAppearance.BorderSize = 0;
            button_decode.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_decode.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_decode.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_decode.FlatStyle = FlatStyle.Flat;
            button_decode.Location = new Point(122, 240);
            button_decode.Name = "button_decode";
            button_decode.Size = new Size(110, 29);
            button_decode.TabIndex = 7;
            button_decode.UseVisualStyleBackColor = false;
            button_decode.Click += button_decode_Click;
            // 
            // button_encode
            // 
            button_encode.BackColor = Color.Transparent;
            button_encode.FlatAppearance.BorderSize = 0;
            button_encode.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_encode.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_encode.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_encode.FlatStyle = FlatStyle.Flat;
            button_encode.Location = new Point(122, 185);
            button_encode.Name = "button_encode";
            button_encode.Size = new Size(110, 29);
            button_encode.TabIndex = 6;
            button_encode.UseVisualStyleBackColor = false;
            button_encode.Click += button_encode_Click;
            // 
            // Lab06_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 476);
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