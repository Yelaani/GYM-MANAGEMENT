namespace SDAM_assignement_2.Forms
{
    partial class Traineravaillability
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
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            tr_user = new TextBox();
            date1 = new TextBox();
            label4 = new Label();
            classtype = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 50);
            label1.Name = "label1";
            label1.Size = new Size(235, 26);
            label1.TabIndex = 0;
            label1.Text = "Enter Trainer Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(187, 101);
            label2.Name = "label2";
            label2.Size = new Size(151, 26);
            label2.TabIndex = 1;
            label2.Text = "Available Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(187, 158);
            label3.Name = "label3";
            label3.Size = new Size(154, 26);
            label3.TabIndex = 2;
            label3.Text = "Available Time:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dateTimePicker1.Location = new Point(440, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 29);
            dateTimePicker1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(110, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(793, 223);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(718, 216);
            button1.Name = "button1";
            button1.Size = new Size(185, 72);
            button1.TabIndex = 7;
            button1.Text = "CONFIRM AVAILABILITY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tr_user
            // 
            tr_user.Location = new Point(440, 47);
            tr_user.Name = "tr_user";
            tr_user.Size = new Size(278, 29);
            tr_user.TabIndex = 8;
            // 
            // date1
            // 
            date1.Location = new Point(440, 155);
            date1.Name = "date1";
            date1.Size = new Size(140, 29);
            date1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(187, 219);
            label4.Name = "label4";
            label4.Size = new Size(64, 26);
            label4.TabIndex = 10;
            label4.Text = "Class:";
            // 
            // classtype
            // 
            classtype.FormattingEnabled = true;
            classtype.Items.AddRange(new object[] { "Bodybuilding", "Kickboxing", "Yoga" });
            classtype.Location = new Point(440, 216);
            classtype.Name = "classtype";
            classtype.Size = new Size(209, 29);
            classtype.TabIndex = 11;
            // 
            // Traineravaillability
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__16_1;
            ClientSize = new Size(1027, 597);
            Controls.Add(classtype);
            Controls.Add(label4);
            Controls.Add(date1);
            Controls.Add(tr_user);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Traineravaillability";
            Text = "Traineravaillability";
            Load += Traineravaillability_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox tr_user;
        private TextBox date1;
        private Label label4;
        private ComboBox classtype;
    }
}