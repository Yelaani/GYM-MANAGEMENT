namespace SDAM_assignement_2.Forms
{
    partial class Trainer
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
            label1.ForeColor = Color.White;
            label1.Location = new Point(169, 120);
            label1.Name = "label1";
            label1.Size = new Size(164, 26);
            label1.TabIndex = 0;
            label1.Text = "Enter Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(169, 185);
            label2.Name = "label2";
            label2.Size = new Size(156, 26);
            label2.TabIndex = 1;
            label2.Text = "Enter Password:";
            // 
            // username
            // 
            username.Location = new Point(343, 120);
            username.Name = "username";
            username.Size = new Size(252, 29);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(343, 185);
            password.Name = "password";
            password.Size = new Size(252, 29);
            password.TabIndex = 3;
            password.TextChanged += password_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(308, 299);
            button1.Name = "button1";
            button1.Size = new Size(118, 56);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Trainer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.trainer1;
            ClientSize = new Size(735, 450);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Trainer";
            Text = "Trainer";
            Load += Trainer_Load;
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