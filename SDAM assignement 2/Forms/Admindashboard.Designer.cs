namespace SDAM_assignement_2.Forms
{
    partial class Admindashboard
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
            classbtn = new Button();
            trainerbtn = new Button();
            memberbtn = new Button();
            SuspendLayout();
            // 
            // classbtn
            // 
            classbtn.BackColor = Color.PaleTurquoise;
            classbtn.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold);
            classbtn.Location = new Point(599, -11);
            classbtn.Name = "classbtn";
            classbtn.Size = new Size(308, 530);
            classbtn.TabIndex = 4;
            classbtn.Text = "MANAGE CLASSES";
            classbtn.UseVisualStyleBackColor = false;
            classbtn.Click += classbtn_Click_1;
            // 
            // trainerbtn
            // 
            trainerbtn.BackColor = Color.LightBlue;
            trainerbtn.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold);
            trainerbtn.Location = new Point(305, -11);
            trainerbtn.Name = "trainerbtn";
            trainerbtn.Size = new Size(296, 530);
            trainerbtn.TabIndex = 3;
            trainerbtn.Text = "MANAGE TRAINERS";
            trainerbtn.UseVisualStyleBackColor = false;
            trainerbtn.Click += trainerbtn_Click;
            // 
            // memberbtn
            // 
            memberbtn.BackColor = Color.LightGray;
            memberbtn.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold);
            memberbtn.Location = new Point(-23, -11);
            memberbtn.Name = "memberbtn";
            memberbtn.Size = new Size(330, 530);
            memberbtn.TabIndex = 2;
            memberbtn.Text = "MANAGE MEMBERS";
            memberbtn.UseVisualStyleBackColor = false;
            memberbtn.Click += memberbtn_Click;
            // 
            // Admindashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 489);
            Controls.Add(classbtn);
            Controls.Add(trainerbtn);
            Controls.Add(memberbtn);
            Name = "Admindashboard";
            Text = "Admindashboard";
            Load += Admindashboard_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button classbtn;
        private Button trainerbtn;
        private Button memberbtn;
    }
}