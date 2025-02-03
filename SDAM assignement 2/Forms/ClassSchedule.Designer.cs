namespace SDAM_assignement_2.Forms
{
    partial class ClassSchedule
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(200, 98);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 0;
            label1.Text = "Class Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(202, 148);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 1;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(200, 200);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 2;
            label3.Text = "Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(200, 247);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 3;
            label4.Text = "Trainer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(200, 293);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 4;
            label5.Text = "Capacity:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 29);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 29);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(324, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 29);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(324, 239);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(199, 29);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(324, 290);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(199, 29);
            textBox5.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(292, 363);
            button1.Name = "button1";
            button1.Size = new Size(130, 60);
            button1.TabIndex = 10;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ClassSchedule
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__26_1;
            ClientSize = new Size(732, 543);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClassSchedule";
            Text = "ClassSchedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}