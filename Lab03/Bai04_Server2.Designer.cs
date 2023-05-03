namespace Lab03
{
    partial class Bai04_Server2
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
            richTextBox1 = new RichTextBox();
            button_listen = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(96, 163);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(609, 212);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button_listen
            // 
            button_listen.Location = new Point(291, 76);
            button_listen.Name = "button_listen";
            button_listen.Size = new Size(180, 45);
            button_listen.TabIndex = 4;
            button_listen.Text = "Listen";
            button_listen.UseVisualStyleBackColor = true;
            button_listen.Click += button_listen_Click;
            // 
            // Bai04_Server2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button_listen);
            Name = "Bai04_Server2";
            Text = "Bai04_Server2";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_listen;
    }
}