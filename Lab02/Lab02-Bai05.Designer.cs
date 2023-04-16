namespace Lab02
{
    partial class Lab02_Bai05
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
            richTextBox_input = new RichTextBox();
            button_zip = new Button();
            button_unzip = new Button();
            SuspendLayout();
            // 
            // richTextBox_input
            // 
            richTextBox_input.Location = new Point(267, 149);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(252, 272);
            richTextBox_input.TabIndex = 9;
            richTextBox_input.Text = "";
            // 
            // button_zip
            // 
            button_zip.Location = new Point(79, 30);
            button_zip.Name = "button_zip";
            button_zip.Size = new Size(153, 68);
            button_zip.TabIndex = 8;
            button_zip.Text = "NÉN THÀNH FILE";
            button_zip.UseVisualStyleBackColor = true;
            button_zip.Click += button_zip_Click;
            // 
            // button_unzip
            // 
            button_unzip.Location = new Point(569, 30);
            button_unzip.Name = "button_unzip";
            button_unzip.Size = new Size(153, 68);
            button_unzip.TabIndex = 7;
            button_unzip.Text = "GIẢI NÉN FILE";
            button_unzip.UseVisualStyleBackColor = true;
            button_unzip.Click += button_unzip_Click;
            // 
            // Lab02_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_input);
            Controls.Add(button_zip);
            Controls.Add(button_unzip);
            Name = "Lab02_Bai05";
            Text = "Lab02_Bai05";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_input;
        private Button button_zip;
        private Button button_unzip;
    }
}