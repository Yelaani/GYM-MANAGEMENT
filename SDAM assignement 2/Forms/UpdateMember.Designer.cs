namespace SDAM_assignement_2.Forms
{
    partial class UpdateMember
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
            textBox1 = new TextBox();
            updatebtn = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(172, 70);
            label1.Name = "label1";
            label1.Size = new Size(179, 26);
            label1.TabIndex = 0;
            label1.Text = "Enter Username :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(441, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 29);
            textBox1.TabIndex = 1;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.DarkSlateGray;
            updatebtn.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            updatebtn.ForeColor = Color.White;
            updatebtn.Location = new Point(697, 119);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(163, 80);
            updatebtn.TabIndex = 2;
            updatebtn.Text = "UPDATE";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(172, 119);
            label2.Name = "label2";
            label2.Size = new Size(246, 26);
            label2.TabIndex = 3;
            label2.Text = "New Telephone Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(172, 169);
            label3.Name = "label3";
            label3.Size = new Size(160, 26);
            label3.TabIndex = 4;
            label3.Text = "New Password :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(441, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 29);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(441, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 29);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(172, 222);
            label4.Name = "label4";
            label4.Size = new Size(147, 26);
            label4.TabIndex = 7;
            label4.Text = "New Address :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(441, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 29);
            textBox4.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(188, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(655, 280);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UpdateMember
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__34_2;
            ClientSize = new Size(1035, 629);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(updatebtn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UpdateMember";
            Text = "UpdateMember";
            Load += UpdateMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button updatebtn;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private DataGridView dataGridView1;
    }
}