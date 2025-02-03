namespace SDAM_assignement_2.Forms
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Tahoma", 12F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(186, 272);
            button1.Name = "button1";
            button1.Size = new Size(178, 59);
            button1.TabIndex = 0;
            button1.Text = "Member login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F);
            button2.Location = new Point(186, 433);
            button2.Name = "button2";
            button2.Size = new Size(178, 59);
            button2.TabIndex = 1;
            button2.Text = "Admin login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Tahoma", 12F);
            button3.Location = new Point(186, 352);
            button3.Name = "button3";
            button3.Size = new Size(178, 59);
            button3.TabIndex = 2;
            button3.Text = "Trainer login";
            button3.TextImageRelation = TextImageRelation.TextAboveImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 10.2F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(198, 202);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 3;
            label1.Text = "Choose your login :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Script MT Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 75);
            label2.Name = "label2";
            label2.Size = new Size(217, 72);
            label2.TabIndex = 4;
            label2.Text = "StepUp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(553, 648);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
    }
}