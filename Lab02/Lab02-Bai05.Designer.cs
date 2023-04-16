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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab02_Bai05));
            richTextBox_input = new RichTextBox();
            button_zip = new Button();
            button_unzip = new Button();
            SuspendLayout();
            // 
            // richTextBox_input
            // 
            richTextBox_input.BackColor = Color.FromArgb(253, 213, 216);
            richTextBox_input.BorderStyle = BorderStyle.None;
            richTextBox_input.Location = new Point(112, 280);
            richTextBox_input.Name = "richTextBox_input";
            richTextBox_input.Size = new Size(710, 237);
            richTextBox_input.TabIndex = 9;
            richTextBox_input.Text = "";
            // 
            // button_zip
            // 
            button_zip.BackColor = Color.FromArgb(242, 182, 187);
            button_zip.FlatStyle = FlatStyle.Flat;
            button_zip.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_zip.Location = new Point(192, 161);
            button_zip.Name = "button_zip";
            button_zip.Size = new Size(141, 68);
            button_zip.TabIndex = 8;
            button_zip.Text = "NÉN FILE";
            button_zip.UseVisualStyleBackColor = false;
            button_zip.Click += button_zip_Click;
            // 
            // button_unzip
            // 
            button_unzip.BackColor = Color.FromArgb(242, 182, 187);
            button_unzip.FlatStyle = FlatStyle.Flat;
            button_unzip.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_unzip.Location = new Point(615, 161);
            button_unzip.Name = "button_unzip";
            button_unzip.Size = new Size(192, 68);
            button_unzip.TabIndex = 7;
            button_unzip.Text = "GIẢI NÉN FILE";
            button_unzip.UseVisualStyleBackColor = false;
            button_unzip.Click += button_unzip_Click;
            // 
            // Lab02_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(961, 539);
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