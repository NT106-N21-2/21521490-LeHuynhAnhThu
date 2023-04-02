namespace Lab01
{
    partial class Lab01_Bai08
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai08));
            listView_output = new ListView();
            button_calculate = new Button();
            button_exit = new Button();
            button_delete = new Button();
            textBox_input = new TextBox();
            SuspendLayout();
            // 
            // listView_output
            // 
            listView_output.AllowColumnReorder = true;
            listView_output.BackColor = Color.FromArgb(252, 248, 241);
            listView_output.BorderStyle = BorderStyle.None;
            listView_output.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView_output.Location = new Point(604, 251);
            listView_output.Name = "listView_output";
            listView_output.Size = new Size(268, 246);
            listView_output.TabIndex = 18;
            listView_output.UseCompatibleStateImageBehavior = false;
            listView_output.View = View.List;
            // 
            // button_calculate
            // 
            button_calculate.BackColor = Color.FromArgb(250, 205, 204);
            button_calculate.FlatStyle = FlatStyle.Flat;
            button_calculate.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_calculate.Location = new Point(405, 236);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(187, 111);
            button_calculate.TabIndex = 17;
            button_calculate.Text = "XỬ LÍ VÀ TỔNG HỢP";
            button_calculate.UseVisualStyleBackColor = false;
            button_calculate.Click += button_calculate_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(250, 205, 204);
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(405, 431);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(187, 71);
            button_exit.TabIndex = 16;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(250, 205, 204);
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(405, 353);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(187, 72);
            button_delete.TabIndex = 15;
            button_delete.Text = "XÓA";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // textBox_input
            // 
            textBox_input.BackColor = Color.FromArgb(252, 248, 241);
            textBox_input.BorderStyle = BorderStyle.None;
            textBox_input.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_input.Location = new Point(415, 122);
            textBox_input.Name = "textBox_input";
            textBox_input.Size = new Size(457, 27);
            textBox_input.TabIndex = 14;
            textBox_input.TextAlign = HorizontalAlignment.Center;
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 519);
            Controls.Add(listView_output);
            Controls.Add(button_calculate);
            Controls.Add(button_exit);
            Controls.Add(button_delete);
            Controls.Add(textBox_input);
            Name = "Lab01_Bai08";
            Text = "Lab01_Bai08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView_output;
        private Button button_calculate;
        private Button button_exit;
        private Button button_delete;
        private TextBox textBox_input;
    }
}