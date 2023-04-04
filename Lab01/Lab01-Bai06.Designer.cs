namespace Lab01
{
    partial class Lab01_Bai06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai06));
            button_exit = new Button();
            button_delete = new Button();
            textBox_num2 = new TextBox();
            textBox_num1 = new TextBox();
            button_calculate = new Button();
            listView_result = new ListView();
            SuspendLayout();
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.FromArgb(250, 205, 204);
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(289, 250);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(138, 74);
            button_exit.TabIndex = 11;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(250, 205, 204);
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(26, 250);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(130, 74);
            button_delete.TabIndex = 10;
            button_delete.Text = "XÓA";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // textBox_num2
            // 
            textBox_num2.BackColor = Color.FromArgb(252, 248, 241);
            textBox_num2.BorderStyle = BorderStyle.None;
            textBox_num2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num2.Location = new Point(200, 123);
            textBox_num2.Name = "textBox_num2";
            textBox_num2.Size = new Size(200, 27);
            textBox_num2.TabIndex = 9;
            textBox_num2.TextAlign = HorizontalAlignment.Center;
            textBox_num2.KeyPress += textBox_num2_KeyPress;
            // 
            // textBox_num1
            // 
            textBox_num1.BackColor = Color.FromArgb(252, 248, 241);
            textBox_num1.BorderStyle = BorderStyle.None;
            textBox_num1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num1.Location = new Point(200, 55);
            textBox_num1.Name = "textBox_num1";
            textBox_num1.Size = new Size(200, 27);
            textBox_num1.TabIndex = 8;
            textBox_num1.TextAlign = HorizontalAlignment.Center;
            textBox_num1.KeyPress += textBox_num1_KeyPress;
            // 
            // button_calculate
            // 
            button_calculate.BackColor = Color.FromArgb(250, 205, 204);
            button_calculate.FlatStyle = FlatStyle.Flat;
            button_calculate.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_calculate.Location = new Point(70, 168);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(314, 72);
            button_calculate.TabIndex = 12;
            button_calculate.Text = "TÍNH CÁC GIÁ TRỊ";
            button_calculate.UseVisualStyleBackColor = false;
            button_calculate.Click += button_calculate_Click;
            // 
            // listView_result
            // 
            listView_result.AllowColumnReorder = true;
            listView_result.BackColor = Color.FromArgb(252, 248, 241);
            listView_result.BorderStyle = BorderStyle.None;
            listView_result.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView_result.Location = new Point(179, 341);
            listView_result.Name = "listView_result";
            listView_result.Size = new Size(240, 166);
            listView_result.TabIndex = 13;
            listView_result.UseCompatibleStateImageBehavior = false;
            listView_result.View = View.List;
            // 
            // Lab01_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(923, 519);
            Controls.Add(listView_result);
            Controls.Add(button_calculate);
            Controls.Add(button_exit);
            Controls.Add(button_delete);
            Controls.Add(textBox_num2);
            Controls.Add(textBox_num1);
            Name = "Lab01_Bai06";
            Text = "Lab01_Bai06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_exit;
        private Button button_delete;
        private TextBox textBox_num2;
        private TextBox textBox_num1;
        private Button button_calculate;
        private ListView listView_result;
    }
}