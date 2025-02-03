namespace SDAM_assignement_2.Forms
{
    partial class Admin
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            username = new TextBox();
            password = new TextBox();
            adminbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(147, 98);
            label1.Name = "label1";
            label1.Size = new Size(226, 26);
            label1.TabIndex = 0;
            label1.Text = "Enter Admin Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(147, 167);
            label2.Name = "label2";
            label2.Size = new Size(156, 26);
            label2.TabIndex = 1;
            label2.Text = "Enter Password:";
            // 
            // username
            // 
            username.Location = new Point(383, 98);
            username.Name = "username";
            username.Size = new Size(230, 29);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(383, 164);
            password.Name = "password";
            password.Size = new Size(230, 29);
            password.TabIndex = 3;
            // 
            // adminbtn
            // 
            adminbtn.BackColor = Color.MidnightBlue;
            adminbtn.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminbtn.ForeColor = Color.FromArgb(255, 255, 192);
            adminbtn.Location = new Point(296, 320);
            adminbtn.Name = "adminbtn";
            adminbtn.Size = new Size(142, 90);
            adminbtn.TabIndex = 5;
            adminbtn.Text = "LOGIN";
            adminbtn.UseVisualStyleBackColor = false;
            adminbtn.Click += adminbtn_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__19_;
            ClientSize = new Size(772, 535);
            Controls.Add(adminbtn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox username;
        private TextBox password;
        private Button adminbtn;
    }
}