namespace SDAM_assignement_2.Forms
{
    partial class Updatetrainer
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
            txtUsername = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            updatebtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 12F);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(273, 74);
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
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(273, 123);
            label2.Name = "label2";
            label2.Size = new Size(234, 26);
            label2.TabIndex = 1;
            label2.Text = "New Telephone Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 12F);
            label3.ForeColor = Color.LavenderBlush;
            label3.Location = new Point(273, 170);
            label3.Name = "label3";
            label3.Size = new Size(146, 26);
            label3.TabIndex = 2;
            label3.Text = "New Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 12F);
            label4.ForeColor = Color.LavenderBlush;
            label4.Location = new Point(273, 217);
            label4.Name = "label4";
            label4.Size = new Size(132, 26);
            label4.TabIndex = 3;
            label4.Text = "New Address:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(520, 74);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(273, 29);
            txtUsername.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(520, 123);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(273, 29);
            txtPhone.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(520, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(273, 29);
            txtPassword.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(520, 217);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(273, 29);
            txtAddress.TabIndex = 7;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.LightSeaGreen;
            updatebtn.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.ForeColor = Color.Black;
            updatebtn.Location = new Point(828, 119);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(163, 80);
            updatebtn.TabIndex = 8;
            updatebtn.Text = "UPDATE";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(289, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(650, 233);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Updatetrainer
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__35_;
            ClientSize = new Size(1205, 584);
            Controls.Add(dataGridView1);
            Controls.Add(updatebtn);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Updatetrainer";
            Text = "Updatetrainer";
            Load += Updatetrainer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtAddress;
        private Button updatebtn;
        private DataGridView dataGridView1;
    }
}