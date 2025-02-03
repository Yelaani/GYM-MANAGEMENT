namespace SDAM_assignement_2.Forms
{
    partial class AdminMember
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
            dataGridView = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Trebuchet MS", 10.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(76, 60);
            button1.Name = "button1";
            button1.Size = new Size(193, 56);
            button1.TabIndex = 1;
            button1.Text = "ADD NEW MEMBER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Font = new Font("Trebuchet MS", 10.8F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(310, 60);
            button2.Name = "button2";
            button2.Size = new Size(193, 56);
            button2.TabIndex = 2;
            button2.Text = "UPDATE MEMBER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Trebuchet MS", 10.8F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(546, 60);
            button3.Name = "button3";
            button3.Size = new Size(193, 56);
            button3.TabIndex = 3;
            button3.Text = "DELETE MEMBER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.Linen;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(310, 158);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(509, 206);
            dataGridView.TabIndex = 4;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Peru;
            button4.Font = new Font("Trebuchet MS", 10.8F);
            button4.Location = new Point(74, 158);
            button4.Name = "button4";
            button4.Size = new Size(193, 80);
            button4.TabIndex = 5;
            button4.Text = "VIEW MEMBER PAYMENT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Peru;
            button5.Font = new Font("Trebuchet MS", 10.8F);
            button5.Location = new Point(74, 285);
            button5.Name = "button5";
            button5.Size = new Size(193, 79);
            button5.TabIndex = 6;
            button5.Text = "VIEW MEMBER REGISTRATIONS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // AdminMember
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImage = Properties.Resources.Untitled_design__21_1;
            ClientSize = new Size(889, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Trebuchet MS", 10.8F);
            ForeColor = Color.White;
            Name = "AdminMember";
            Text = "AdminMember";
            Load += AdminMember_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView;
        private Button button4;
        private Button button5;
    }
}