namespace SDAM_assignement_2
{
    partial class NewMember
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
            fname = new TextBox();
            Lname = new TextBox();
            Male = new RadioButton();
            Female = new RadioButton();
            label4 = new Label();
            DOB = new DateTimePicker();
            label5 = new Label();
            tele = new TextBox();
            address = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            Nuser = new TextBox();
            label9 = new Label();
            Npass = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(243, 85);
            label1.Name = "label1";
            label1.Size = new Size(111, 26);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(243, 140);
            label2.Name = "label2";
            label2.Size = new Size(107, 26);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(243, 189);
            label3.Name = "label3";
            label3.Size = new Size(78, 26);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // fname
            // 
            fname.Location = new Point(425, 77);
            fname.Name = "fname";
            fname.Size = new Size(299, 29);
            fname.TabIndex = 3;
            // 
            // Lname
            // 
            Lname.Location = new Point(425, 132);
            Lname.Name = "Lname";
            Lname.Size = new Size(299, 29);
            Lname.TabIndex = 4;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.BackColor = Color.Transparent;
            Male.Checked = true;
            Male.Font = new Font("Trebuchet MS", 12F);
            Male.ForeColor = Color.Lavender;
            Male.Location = new Point(425, 185);
            Male.Name = "Male";
            Male.Size = new Size(76, 30);
            Male.TabIndex = 5;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = false;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.BackColor = Color.Transparent;
            Female.Font = new Font("Trebuchet MS", 12F);
            Female.ForeColor = Color.Lavender;
            Female.Location = new Point(518, 185);
            Female.Name = "Female";
            Female.Size = new Size(100, 30);
            Female.TabIndex = 6;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(243, 237);
            label4.Name = "label4";
            label4.Size = new Size(128, 26);
            label4.TabIndex = 7;
            label4.Text = "Date of Birth";
            // 
            // DOB
            // 
            DOB.Location = new Point(425, 231);
            DOB.Name = "DOB";
            DOB.Size = new Size(299, 29);
            DOB.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(243, 288);
            label5.Name = "label5";
            label5.Size = new Size(140, 26);
            label5.TabIndex = 9;
            label5.Text = "Telephone no.";
            // 
            // tele
            // 
            tele.Location = new Point(425, 285);
            tele.Name = "tele";
            tele.Size = new Size(200, 29);
            tele.TabIndex = 10;
            // 
            // address
            // 
            address.Location = new Point(425, 341);
            address.Name = "address";
            address.Size = new Size(299, 110);
            address.TabIndex = 11;
            address.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Trebuchet MS", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(243, 344);
            label6.Name = "label6";
            label6.Size = new Size(70, 26);
            label6.TabIndex = 12;
            label6.Text = "Adress";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 430);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(797, 570);
            button1.Name = "button1";
            button1.Size = new Size(140, 56);
            button1.TabIndex = 16;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(960, 570);
            button2.Name = "button2";
            button2.Size = new Size(140, 56);
            button2.TabIndex = 17;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Trebuchet MS", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(243, 486);
            label8.Name = "label8";
            label8.Size = new Size(102, 26);
            label8.TabIndex = 18;
            label8.Text = "Username";
            label8.Click += label8_Click;
            // 
            // Nuser
            // 
            Nuser.Location = new Point(425, 483);
            Nuser.Name = "Nuser";
            Nuser.Size = new Size(299, 29);
            Nuser.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Trebuchet MS", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(243, 545);
            label9.Name = "label9";
            label9.Size = new Size(94, 26);
            label9.TabIndex = 20;
            label9.Text = "Password";
            // 
            // Npass
            // 
            Npass.Location = new Point(425, 542);
            Npass.Name = "Npass";
            Npass.Size = new Size(299, 29);
            Npass.TabIndex = 21;
            // 
            // NewMember
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__31_;
            ClientSize = new Size(1166, 689);
            Controls.Add(Npass);
            Controls.Add(label9);
            Controls.Add(Nuser);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(address);
            Controls.Add(tele);
            Controls.Add(label5);
            Controls.Add(DOB);
            Controls.Add(label4);
            Controls.Add(Female);
            Controls.Add(Male);
            Controls.Add(Lname);
            Controls.Add(fname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewMember";
            Text = "NewMember";
            Load += NewMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox fname;
        private TextBox Lname;
        private RadioButton Male;
        private RadioButton Female;
        private Label label4;
        private DateTimePicker DOB;
        private Label label5;
        private TextBox tele;
        private RichTextBox address;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Label label8;
        private TextBox Nuser;
        private Label label9;
        private TextBox Npass;
    }
}