namespace SDAM_assignement_2.Forms
{
    partial class Memberattendance
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            User = new TextBox();
            Date = new TextBox();
            Time = new TextBox();
            comboBox1 = new ComboBox();
            Present = new RadioButton();
            Absent = new RadioButton();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 13.2000008F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(241, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "Member name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 13.2000008F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(241, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 1;
            label2.Text = "Class";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 13.2000008F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(241, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 13.2000008F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(241, 227);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 3;
            label4.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 13.2000008F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(238, 292);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 28);
            label5.TabIndex = 4;
            label5.Text = "Attendance:";
            // 
            // User
            // 
            User.Location = new Point(450, 51);
            User.Margin = new Padding(4);
            User.Name = "User";
            User.Size = new Size(308, 31);
            User.TabIndex = 5;
            // 
            // Date
            // 
            Date.Location = new Point(450, 164);
            Date.Margin = new Padding(4);
            Date.Name = "Date";
            Date.Size = new Size(308, 31);
            Date.TabIndex = 7;
            // 
            // Time
            // 
            Time.Location = new Point(450, 223);
            Time.Margin = new Padding(4);
            Time.Name = "Time";
            Time.Size = new Size(308, 31);
            Time.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bodybuilding", "Kickboxing", "Yoga" });
            comboBox1.Location = new Point(453, 105);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(294, 34);
            comboBox1.TabIndex = 9;
            // 
            // Present
            // 
            Present.AutoSize = true;
            Present.BackColor = Color.Transparent;
            Present.Font = new Font("Trebuchet MS", 12F);
            Present.ForeColor = Color.LightGoldenrodYellow;
            Present.Location = new Point(450, 288);
            Present.Margin = new Padding(4);
            Present.Name = "Present";
            Present.Size = new Size(100, 30);
            Present.TabIndex = 10;
            Present.TabStop = true;
            Present.Text = "Present";
            Present.UseVisualStyleBackColor = false;
            // 
            // Absent
            // 
            Absent.AutoSize = true;
            Absent.BackColor = Color.Transparent;
            Absent.Font = new Font("Trebuchet MS", 12F);
            Absent.ForeColor = Color.LightGoldenrodYellow;
            Absent.Location = new Point(611, 288);
            Absent.Margin = new Padding(4);
            Absent.Name = "Absent";
            Absent.Size = new Size(94, 30);
            Absent.TabIndex = 11;
            Absent.TabStop = true;
            Absent.Text = "Absent";
            Absent.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.SeaShell;
            dataGridView1.Location = new Point(118, 349);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(908, 270);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(862, 254);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(164, 64);
            button1.TabIndex = 13;
            button1.Text = "CONFIRM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Memberattendance
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__12_;
            ClientSize = new Size(1169, 677);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Absent);
            Controls.Add(Present);
            Controls.Add(comboBox1);
            Controls.Add(Time);
            Controls.Add(Date);
            Controls.Add(User);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Trebuchet MS", 12F);
            Margin = new Padding(4);
            Name = "Memberattendance";
            Text = "Memberattendance";
            Load += Memberattendance_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox User;
        private TextBox Date;
        private TextBox Time;
        private ComboBox comboBox1;
        private RadioButton Present;
        private RadioButton Absent;
        private DataGridView dataGridView1;
        private Button button1;
    }
}