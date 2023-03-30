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
            button_exit.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(559, 147);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(84, 35);
            button_exit.TabIndex = 11;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(374, 147);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(84, 35);
            button_delete.TabIndex = 10;
            button_delete.Text = "XÓA";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // textBox_num2
            // 
            textBox_num2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num2.Location = new Point(630, 61);
            textBox_num2.Name = "textBox_num2";
            textBox_num2.Size = new Size(106, 28);
            textBox_num2.TabIndex = 9;
            textBox_num2.TextAlign = HorizontalAlignment.Center;
            textBox_num2.KeyPress += textBox_num2_KeyPress;
            // 
            // textBox_num1
            // 
            textBox_num1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_num1.Location = new Point(216, 61);
            textBox_num1.Name = "textBox_num1";
            textBox_num1.Size = new Size(106, 28);
            textBox_num1.TabIndex = 8;
            textBox_num1.TextAlign = HorizontalAlignment.Center;
            textBox_num1.KeyPress += textBox_num1_KeyPress;
            // 
            // button_calculate
            // 
            button_calculate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_calculate.Location = new Point(82, 147);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(184, 35);
            button_calculate.TabIndex = 12;
            button_calculate.Text = "TÍNH CÁC GIÁ TRỊ";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // listView_result
            // 
            listView_result.AllowColumnReorder = true;
            listView_result.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listView_result.Location = new Point(312, 260);
            listView_result.Name = "listView_result";
            listView_result.Size = new Size(220, 154);
            listView_result.TabIndex = 13;
            listView_result.UseCompatibleStateImageBehavior = false;
            listView_result.View = View.List;
            // 
            // Lab01_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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