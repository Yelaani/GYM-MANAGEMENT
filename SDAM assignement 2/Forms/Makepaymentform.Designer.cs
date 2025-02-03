namespace SDAM_assignement_2.Forms
{
    partial class Makepaymentform
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
            payment = new Label();
            username = new TextBox();
            ontranfer = new RadioButton();
            card = new RadioButton();
            confirm = new Button();
            calculation = new RichTextBox();
            month = new NumericUpDown();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)month).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(305, 86);
            label1.Name = "label1";
            label1.Size = new Size(109, 26);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(303, 145);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 1;
            label2.Text = "No. of months:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(304, 206);
            label3.Name = "label3";
            label3.Size = new Size(187, 26);
            label3.TabIndex = 2;
            label3.Text = "Amount to be paid:";
            // 
            // payment
            // 
            payment.AutoSize = true;
            payment.BackColor = Color.Transparent;
            payment.Font = new Font("Trebuchet MS", 12F);
            payment.ForeColor = Color.White;
            payment.Location = new Point(306, 320);
            payment.Name = "payment";
            payment.Size = new Size(172, 26);
            payment.TabIndex = 3;
            payment.Text = "Payment method:";
            // 
            // username
            // 
            username.Font = new Font("Tahoma", 10.8F);
            username.Location = new Point(522, 81);
            username.Name = "username";
            username.Size = new Size(283, 29);
            username.TabIndex = 4;
            username.TextChanged += username_TextChanged;
            // 
            // ontranfer
            // 
            ontranfer.AutoSize = true;
            ontranfer.BackColor = Color.Transparent;
            ontranfer.Font = new Font("Trebuchet MS", 12F);
            ontranfer.ForeColor = Color.LightYellow;
            ontranfer.Location = new Point(522, 319);
            ontranfer.Name = "ontranfer";
            ontranfer.Size = new Size(169, 30);
            ontranfer.TabIndex = 7;
            ontranfer.TabStop = true;
            ontranfer.Text = "Online transfer";
            ontranfer.UseVisualStyleBackColor = false;
            ontranfer.CheckedChanged += ontranfer_CheckedChanged;
            // 
            // card
            // 
            card.AutoSize = true;
            card.BackColor = Color.Transparent;
            card.Font = new Font("Trebuchet MS", 12F);
            card.ForeColor = Color.LightYellow;
            card.Location = new Point(522, 350);
            card.Name = "card";
            card.Size = new Size(160, 30);
            card.TabIndex = 8;
            card.TabStop = true;
            card.Text = "Card payment";
            card.UseVisualStyleBackColor = false;
            // 
            // confirm
            // 
            confirm.BackColor = Color.ForestGreen;
            confirm.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm.ForeColor = Color.White;
            confirm.Location = new Point(805, 424);
            confirm.Name = "confirm";
            confirm.Size = new Size(173, 60);
            confirm.TabIndex = 9;
            confirm.Text = "CONFIRM PAYMENT";
            confirm.UseVisualStyleBackColor = false;
            confirm.Click += button1_Click;
            // 
            // calculation
            // 
            calculation.Font = new Font("Tahoma", 10.8F);
            calculation.Location = new Point(520, 206);
            calculation.Name = "calculation";
            calculation.Size = new Size(285, 81);
            calculation.TabIndex = 10;
            calculation.Text = "";
            calculation.TextChanged += calculation_TextChanged;
            // 
            // month
            // 
            month.Font = new Font("Tahoma", 10.8F);
            month.Location = new Point(522, 140);
            month.Name = "month";
            month.Size = new Size(100, 29);
            month.TabIndex = 11;
            month.ValueChanged += month_ValueChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Tahoma", 10.8F);
            button2.ForeColor = Color.FromArgb(0, 64, 0);
            button2.Location = new Point(663, 138);
            button2.Name = "button2";
            button2.Size = new Size(142, 31);
            button2.TabIndex = 12;
            button2.Text = "click to view amount";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Makepaymentform
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = Properties.Resources.Untitled_design__8_;
            ClientSize = new Size(1079, 541);
            Controls.Add(button2);
            Controls.Add(month);
            Controls.Add(calculation);
            Controls.Add(confirm);
            Controls.Add(card);
            Controls.Add(ontranfer);
            Controls.Add(username);
            Controls.Add(payment);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Makepaymentform";
            Text = "Makepaymentform";
            Load += Makepaymentform_Load;
            ((System.ComponentModel.ISupportInitialize)month).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label payment;
        private TextBox username;
        private RadioButton ontranfer;
        private RadioButton card;
        private Button confirm;
        private RichTextBox calculation;
        private NumericUpDown month;
        private Button button2;
    }
}