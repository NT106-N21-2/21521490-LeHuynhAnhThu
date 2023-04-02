namespace Lab01
{
    partial class Lab01_Bai07
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
            button_calculate = new Button();
            button_exit = new Button();
            button_delete = new Button();
            textBox_input = new TextBox();
            textBox_numSubnet = new TextBox();
            STT = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridView_output = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView_output).BeginInit();
            SuspendLayout();
            // 
            // button_calculate
            // 
            button_calculate.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_calculate.Location = new Point(515, 126);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new Size(142, 35);
            button_calculate.TabIndex = 22;
            button_calculate.Text = "CHIA MẠNG";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += button_calculate_Click;
            // 
            // button_exit
            // 
            button_exit.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(704, 126);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(84, 35);
            button_exit.TabIndex = 21;
            button_exit.Text = "THOÁT";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_delete.Location = new Point(349, 126);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(84, 35);
            button_delete.TabIndex = 20;
            button_delete.Text = "XÓA";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // textBox_input
            // 
            textBox_input.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_input.Location = new Point(595, 25);
            textBox_input.Name = "textBox_input";
            textBox_input.Size = new Size(193, 28);
            textBox_input.TabIndex = 19;
            textBox_input.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_numSubnet
            // 
            textBox_numSubnet.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_numSubnet.Location = new Point(595, 70);
            textBox_numSubnet.Name = "textBox_numSubnet";
            textBox_numSubnet.Size = new Size(193, 28);
            textBox_numSubnet.TabIndex = 24;
            textBox_numSubnet.TextAlign = HorizontalAlignment.Center;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "STT";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView_output
            // 
            dataGridView_output.BackgroundColor = SystemColors.Control;
            dataGridView_output.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_output.Location = new Point(12, 185);
            dataGridView_output.Name = "dataGridView_output";
            dataGridView_output.RowHeadersWidth = 51;
            dataGridView_output.RowTemplate.Height = 29;
            dataGridView_output.Size = new Size(776, 253);
            dataGridView_output.TabIndex = 25;
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_output);
            Controls.Add(textBox_numSubnet);
            Controls.Add(button_calculate);
            Controls.Add(button_exit);
            Controls.Add(button_delete);
            Controls.Add(textBox_input);
            Name = "Lab01_Bai07";
            Text = "Lab01_Bai07";
            ((System.ComponentModel.ISupportInitialize)dataGridView_output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_calculate;
        private Button button_exit;
        private Button button_delete;
        private TextBox textBox_input;
        private TextBox textBox_numSubnet;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView dataGridView_output;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}