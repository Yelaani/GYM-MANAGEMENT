namespace SDAM_assignement_2.Forms
{
    partial class NewTrainer
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
            Npass = new TextBox();
            label9 = new Label();
            Nuser = new TextBox();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            address = new RichTextBox();
            tele = new TextBox();
            label5 = new Label();
            DOB = new DateTimePicker();
            label4 = new Label();
            Female = new RadioButton();
            Male = new RadioButton();
            Lname = new TextBox();
            fname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Npass
            // 
            Npass.Location = new Point(496, 491);
            Npass.Name = "Npass";
            Npass.Size = new Size(313, 29);
            Npass.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Trebuchet MS", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(300, 494);
            label9.Name = "label9";
            label9.Size = new Size(94, 26);
            label9.TabIndex = 40;
            label9.Text = "Password";
            // 
            // Nuser
            // 
            Nuser.Location = new Point(496, 434);
            Nuser.Name = "Nuser";
            Nuser.Size = new Size(313, 29);
            Nuser.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Trebuchet MS", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(300, 442);
            label8.Name = "label8";
            label8.Size = new Size(102, 26);
            label8.TabIndex = 38;
            label8.Text = "Username";
            // 
            // button2
            // 
            button2.BackColor = Color.Salmon;
            button2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button2.Location = new Point(996, 541);
            button2.Name = "button2";
            button2.Size = new Size(143, 61);
            button2.TabIndex = 37;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            button1.Location = new Point(834, 541);
            button1.Name = "button1";
            button1.Size = new Size(141, 61);
            button1.TabIndex = 36;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 431);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Trebuchet MS", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(300, 302);
            label6.Name = "label6";
            label6.Size = new Size(70, 26);
            label6.TabIndex = 34;
            label6.Text = "Adress";
            // 
            // address
            // 
            address.Location = new Point(496, 299);
            address.Name = "address";
            address.Size = new Size(313, 110);
            address.TabIndex = 33;
            address.Text = "";
            // 
            // tele
            // 
            tele.Location = new Point(496, 244);
            tele.Name = "tele";
            tele.Size = new Size(200, 29);
            tele.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(300, 247);
            label5.Name = "label5";
            label5.Size = new Size(140, 26);
            label5.TabIndex = 31;
            label5.Text = "Telephone no.";
            // 
            // DOB
            // 
            DOB.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOB.Location = new Point(496, 191);
            DOB.Name = "DOB";
            DOB.Size = new Size(313, 28);
            DOB.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(300, 197);
            label4.Name = "label4";
            label4.Size = new Size(128, 26);
            label4.TabIndex = 29;
            label4.Text = "Date of Birth";
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.BackColor = Color.Transparent;
            Female.Font = new Font("Trebuchet MS", 12F);
            Female.ForeColor = Color.White;
            Female.Location = new Point(602, 139);
            Female.Name = "Female";
            Female.Size = new Size(100, 30);
            Female.TabIndex = 28;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = false;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.BackColor = Color.Transparent;
            Male.Checked = true;
            Male.Font = new Font("Trebuchet MS", 12F);
            Male.ForeColor = Color.White;
            Male.Location = new Point(496, 139);
            Male.Name = "Male";
            Male.Size = new Size(76, 30);
            Male.TabIndex = 27;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = false;
            // 
            // Lname
            // 
            Lname.Location = new Point(496, 85);
            Lname.Name = "Lname";
            Lname.Size = new Size(313, 29);
            Lname.TabIndex = 26;
            // 
            // fname
            // 
            fname.Location = new Point(496, 32);
            fname.Name = "fname";
            fname.Size = new Size(313, 29);
            fname.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(300, 143);
            label3.Name = "label3";
            label3.Size = new Size(78, 26);
            label3.TabIndex = 24;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(300, 93);
            label2.Name = "label2";
            label2.Size = new Size(107, 26);
            label2.TabIndex = 23;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(300, 40);
            label1.Name = "label1";
            label1.Size = new Size(111, 26);
            label1.TabIndex = 22;
            label1.Text = "First Name";
            // 
            // NewTrainer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_02_03_at_10_51_12_aa1da4ae;
            ClientSize = new Size(1190, 633);
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
            Name = "NewTrainer";
            Text = "NewTrainer";
            Load += NewTrainer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Npass;
        private Label label9;
        private TextBox Nuser;
        private Label label8;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label6;
        private RichTextBox address;
        private TextBox tele;
        private Label label5;
        private DateTimePicker DOB;
        private Label label4;
        private RadioButton Female;
        private RadioButton Male;
        private TextBox Lname;
        private TextBox fname;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}