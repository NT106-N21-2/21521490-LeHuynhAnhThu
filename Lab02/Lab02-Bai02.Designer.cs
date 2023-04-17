namespace Lab02
{
    partial class Lab02_Bai02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab02_Bai02));
            button_read = new Button();
            textBox_name = new TextBox();
            textBox_url = new TextBox();
            textBox_size = new TextBox();
            textBox_line = new TextBox();
            textBox_word = new TextBox();
            textBox_character = new TextBox();
            richTextBox_input = new RichTextBox();
            SuspendLayout();
            // 
            // button_read
            // 
            button_read.BackColor = Color.FromArgb(242, 182, 187);
            button_read.FlatStyle = FlatStyle.Flat;
            button_read.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_read.Location = new Point(117, 146);
            button_read.Name = "button_read";
            button_read.Size = new Size(182, 69);
            button_read.TabIndex = 0;
            button_read.Text = "ĐỌC TỪ FILE";
            button_read.UseVisualStyleBackColor = false;
            button_read.Click += button_read_Click;
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.FromArgb(255, 215, 218);
            textBox_name.BorderStyle = BorderStyle.None;
            textBox_name.Location = new Point(617, 168);
            textBox_name.Name = "textBox_name";
            textBox_name.ReadOnly = true;
            textBox_name.Size = new Size(257, 20);
            textBox_name.TabIndex = 1;
            // 
            // textBox_url
            // 
            textBox_url.BackColor = Color.FromArgb(255, 215, 218);
            textBox_url.BorderStyle = BorderStyle.None;
            textBox_url.Location = new Point(617, 298);
            textBox_url.Name = "textBox_url";
            textBox_url.ReadOnly = true;
            textBox_url.Size = new Size(257, 20);
            textBox_url.TabIndex = 2;
            // 
            // textBox_size
            // 
            textBox_size.BackColor = Color.FromArgb(255, 215, 218);
            textBox_size.BorderStyle = BorderStyle.None;
            textBox_size.Location = new Point(617, 235);
            textBox_size.Name = "textBox_size";
            textBox_size.ReadOnly = true;
            textBox_size.Size = new Size(257, 20);
            textBox_size.TabIndex = 3;
            // 
            // textBox_line
            // 
            textBox_line.BackColor = Color.FromArgb(255, 215, 218);
            textBox_line.BorderStyle = BorderStyle.None;
            textBox_line.Location = new Point(617, 359);
            textBox_line.Name = "textBox_line";
            textBox_line.ReadOnly = true;
            textBox_line.Size = new Size(257, 20);
            textBox_line.TabIndex = 4;
            // 
            // textBox_word
            // 
            textBox_word.BackColor = Color.FromArgb(255, 215, 218);
            textBox_word.BorderStyle = BorderStyle.None;
            textBox_word.Location = new Point(617, 422);
            textBox_word.Name = "textBox_word";
            textBox_word.ReadOnly = true;
            textBox_word.Size = new Size(257, 20);
            textBox_word.TabIndex = 5;
            // 
            // textBox_character
            // 
            textBox_character.BackColor = Color.FromArgb(255, 215, 218);
            textBox_character.BorderStyle = BorderStyle.None;
            textBox_character.Location = new Point(617, 486);
            textBox_character.Name = "textBox_character";
            textBox_character.ReadOnly = true;
            textBox_character.Size = new Size(257, 20);
            textBox_character.TabIndex = 6;
            // 
            // richTextBox_input
            // 
            richTextBox_input.BackColor = Color.FromArgb(255, 215, 218);
            richTextBox_input.BorderStyle = BorderStyle.None;
            richTextBox_input.Location = new Point(27, 259);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(358, 258);
            richTextBox_input.TabIndex = 7;
            richTextBox_input.Text = "";
            // 
            // Lab02_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(961, 539);
            Controls.Add(richTextBox_input);
            Controls.Add(textBox_character);
            Controls.Add(textBox_word);
            Controls.Add(textBox_line);
            Controls.Add(textBox_size);
            Controls.Add(textBox_url);
            Controls.Add(textBox_name);
            Controls.Add(button_read);
            Name = "Lab02_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_read;
        private TextBox textBox_name;
        private TextBox textBox_url;
        private TextBox textBox_size;
        private TextBox textBox_line;
        private TextBox textBox_word;
        private TextBox textBox_character;
        private RichTextBox richTextBox_input;
    }
}