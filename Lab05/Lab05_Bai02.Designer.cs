namespace Lab05
{
    partial class Lab05_Bai02
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
            button_Login = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // button_Login
            // 
            button_Login.Location = new Point(576, 54);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 29);
            button_Login.TabIndex = 0;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 27);
            textBox2.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(23, 116);
            listView1.Name = "listView1";
            listView1.Size = new Size(789, 301);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Lab05_Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(listView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button_Login);
            Name = "Lab05_Bai02";
            Text = "Lab05_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Login;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListView listView1;
    }
}