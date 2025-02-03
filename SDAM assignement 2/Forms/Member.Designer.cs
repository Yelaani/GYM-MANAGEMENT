namespace SDAM_assignement_2.Forms
{
    partial class Member
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
            username = new TextBox();
            password = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(163, 136);
            label1.Name = "label1";
            label1.Size = new Size(164, 26);
            label1.TabIndex = 0;
            label1.Text = "Enter Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(163, 197);
            label2.Name = "label2";
            label2.Size = new Size(156, 26);
            label2.TabIndex = 1;
            label2.Text = "Enter Password:";
            // 
            // username
            // 
            username.Font = new Font("Tahoma", 10.8F);
            username.Location = new Point(329, 133);
            username.Name = "username";
            username.Size = new Size(281, 29);
            username.TabIndex = 2;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.Font = new Font("Tahoma", 10.8F);
            password.Location = new Point(329, 197);
            password.Name = "password";
            password.Size = new Size(281, 29);
            password.TabIndex = 3;
            password.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(313, 299);
            button1.Name = "button1";
            button1.Size = new Size(113, 50);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__1_;
            ClientSize = new Size(734, 472);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Member";
            Text = "Membercs";
            Load += Member_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Button button1;
    }
}