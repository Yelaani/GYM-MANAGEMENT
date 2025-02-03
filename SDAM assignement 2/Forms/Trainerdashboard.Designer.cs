namespace SDAM_assignement_2.Forms
{
    partial class Trainerdashboard
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
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Trebuchet MS", 12F);
            button1.Location = new Point(85, 65);
            button1.Name = "button1";
            button1.Size = new Size(186, 61);
            button1.TabIndex = 0;
            button1.Text = "Mark Attendance";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Trebuchet MS", 12F);
            button3.Location = new Point(85, 217);
            button3.Name = "button3";
            button3.Size = new Size(186, 61);
            button3.TabIndex = 5;
            button3.Text = "View Schedule";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(295, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(505, 241);
            dataGridView1.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Trebuchet MS", 12F);
            button2.Location = new Point(323, 65);
            button2.Name = "button2";
            button2.Size = new Size(216, 61);
            button2.TabIndex = 7;
            button2.Text = "Confirm Availability";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Trebuchet MS", 12F);
            button4.Location = new Point(598, 65);
            button4.Name = "button4";
            button4.Size = new Size(202, 61);
            button4.TabIndex = 8;
            button4.Text = "View Payments";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Trainerdashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Untitled_design__11_;
            ClientSize = new Size(900, 467);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Trainerdashboard";
            Text = "Trainerdashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button4;
    }
}