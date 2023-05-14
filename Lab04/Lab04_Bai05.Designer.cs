namespace Lab04
{
    partial class Lab04_Bai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab04_Bai05));
            panel_web = new Panel();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // panel_web
            // 
            panel_web.AutoScroll = true;
            panel_web.BackColor = Color.Pink;
            panel_web.Location = new Point(12, 151);
            panel_web.Name = "panel_web";
            panel_web.Size = new Size(776, 280);
            panel_web.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(490, 74);
            button2.Name = "button2";
            button2.Size = new Size(82, 29);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += back_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(723, 74);
            button3.Name = "button3";
            button3.Size = new Size(65, 29);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += next_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(148, 63);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(368, 63);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(206, 107);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(368, 107);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 9;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 445);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(104, 22);
            progressBar.TabIndex = 10;
            progressBar.Click += progressBar_Click;
            // 
            // Lab04_Bai05
            // 
            AccessibleRole = AccessibleRole.ScrollBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 479);
            Controls.Add(progressBar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel_web);
            Name = "Lab04_Bai05";
            Text = "Lab04_Bai05";
            Load += Lab04_Bai05_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel_web;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ProgressBar progressBar;
    }
}