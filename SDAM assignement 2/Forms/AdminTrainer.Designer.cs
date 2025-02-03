namespace SDAM_assignement_2.Forms
{
    partial class AdminTrainer
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(91, 60);
            button2.Name = "button2";
            button2.Size = new Size(194, 55);
            button2.TabIndex = 2;
            button2.Text = "ADD TRAINER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(562, 60);
            button1.Name = "button1";
            button1.Size = new Size(194, 55);
            button1.TabIndex = 3;
            button1.Text = "DELETE TRAINER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(325, 60);
            button3.Name = "button3";
            button3.Size = new Size(194, 55);
            button3.TabIndex = 4;
            button3.Text = "UPDATE TRAINER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(91, 178);
            button4.Name = "button4";
            button4.Size = new Size(194, 55);
            button4.TabIndex = 5;
            button4.Text = "SALARY PAYMENTS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(91, 304);
            button5.Name = "button5";
            button5.Size = new Size(194, 55);
            button5.TabIndex = 6;
            button5.Text = "AVAILABILITY";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(438, 216);
            dataGridView1.TabIndex = 7;
            // 
            // AdminTrainer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__22_2;
            ClientSize = new Size(892, 467);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "AdminTrainer";
            Text = "AdminTrainer";
            Load += AdminTrainer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
    }
}