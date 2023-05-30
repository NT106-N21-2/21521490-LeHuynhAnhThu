namespace Lab05
{
    partial class Lab05_Bai01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab05_Bai01));
            button_send = new Button();
            textBox_subject = new TextBox();
            textBox_to = new TextBox();
            richTextBox_body = new RichTextBox();
            textBox_from = new TextBox();
            SuspendLayout();
            // 
            // button_send
            // 
            button_send.BackColor = Color.Transparent;
            button_send.FlatAppearance.BorderSize = 0;
            button_send.FlatStyle = FlatStyle.Flat;
            button_send.ForeColor = Color.Transparent;
            button_send.Location = new Point(114, 57);
            button_send.Name = "button_send";
            button_send.Size = new Size(75, 71);
            button_send.TabIndex = 0;
            button_send.UseVisualStyleBackColor = false;
            button_send.Click += button_send_Click;
            // 
            // textBox_subject
            // 
            textBox_subject.BackColor = Color.FromArgb(239, 207, 49);
            textBox_subject.BorderStyle = BorderStyle.None;
            textBox_subject.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_subject.ForeColor = Color.FromArgb(28, 96, 148);
            textBox_subject.Location = new Point(177, 188);
            textBox_subject.Name = "textBox_subject";
            textBox_subject.Size = new Size(604, 23);
            textBox_subject.TabIndex = 2;
            // 
            // textBox_to
            // 
            textBox_to.BackColor = Color.FromArgb(239, 207, 49);
            textBox_to.BorderStyle = BorderStyle.None;
            textBox_to.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_to.ForeColor = Color.FromArgb(28, 96, 148);
            textBox_to.Location = new Point(349, 125);
            textBox_to.Name = "textBox_to";
            textBox_to.Size = new Size(421, 23);
            textBox_to.TabIndex = 3;
            // 
            // richTextBox_body
            // 
            richTextBox_body.Location = new Point(51, 217);
            richTextBox_body.Name = "richTextBox_body";
            richTextBox_body.Size = new Size(742, 221);
            richTextBox_body.TabIndex = 4;
            richTextBox_body.Text = "";
            // 
            // textBox_from
            // 
            textBox_from.BackColor = Color.FromArgb(239, 207, 49);
            textBox_from.BorderStyle = BorderStyle.None;
            textBox_from.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_from.ForeColor = Color.FromArgb(28, 96, 148);
            textBox_from.Location = new Point(352, 60);
            textBox_from.Name = "textBox_from";
            textBox_from.ReadOnly = true;
            textBox_from.Size = new Size(421, 23);
            textBox_from.TabIndex = 5;
            textBox_from.Text = "21521490@gm.uit.edu.vn";
            // 
            // Lab05_Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(820, 457);
            Controls.Add(textBox_from);
            Controls.Add(richTextBox_body);
            Controls.Add(textBox_to);
            Controls.Add(textBox_subject);
            Controls.Add(button_send);
            Name = "Lab05_Bai01";
            Text = "Lab05_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_send;
        private TextBox textBox_subject;
        private TextBox textBox_to;
        private RichTextBox richTextBox_body;
        private TextBox textBox_from;
    }
}