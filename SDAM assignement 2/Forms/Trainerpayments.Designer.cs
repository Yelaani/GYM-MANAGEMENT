namespace SDAM_assignement_2.Forms
{
    partial class Trainerpayments
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
            trname = new TextBox();
            Date = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 81);
            label1.Name = "label1";
            label1.Size = new Size(180, 26);
            label1.TabIndex = 0;
            label1.Text = "Trainer Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(214, 141);
            label2.Name = "label2";
            label2.Size = new Size(170, 26);
            label2.TabIndex = 1;
            label2.Text = "Date of payment:";
            // 
            // trname
            // 
            trname.Location = new Point(422, 78);
            trname.Name = "trname";
            trname.Size = new Size(274, 29);
            trname.TabIndex = 2;
            // 
            // Date
            // 
            Date.Location = new Point(422, 138);
            Date.Name = "Date";
            Date.Size = new Size(274, 29);
            Date.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(129, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(664, 241);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Trebuchet MS", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(621, 193);
            button1.Name = "button1";
            button1.Size = new Size(172, 51);
            button1.TabIndex = 33;
            button1.Text = "MAKE PAYMENT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Trainerpayments
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__8_2;
            ClientSize = new Size(903, 551);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Date);
            Controls.Add(trname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Trainerpayments";
            Text = "Trainerpayments";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox trname;
        private DateTimePicker Date;
        private DataGridView dataGridView1;
        private Button button1;
    }
}