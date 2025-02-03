namespace SDAM_assignement_2.Forms
{
    partial class Register
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
            UserName = new Label();
            SelectClass = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Tahoma", 10.8F);
            button1.Location = new Point(605, 190);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(131, 61);
            button1.TabIndex = 0;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.Transparent;
            UserName.Font = new Font("Trebuchet MS", 12F);
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(219, 80);
            UserName.Margin = new Padding(4, 0, 4, 0);
            UserName.Name = "UserName";
            UserName.Size = new Size(164, 26);
            UserName.TabIndex = 1;
            UserName.Text = "Enter Username:";
            // 
            // SelectClass
            // 
            SelectClass.AutoSize = true;
            SelectClass.BackColor = Color.Transparent;
            SelectClass.Font = new Font("Trebuchet MS", 12F);
            SelectClass.ForeColor = Color.White;
            SelectClass.Location = new Point(219, 142);
            SelectClass.Margin = new Padding(4, 0, 4, 0);
            SelectClass.Name = "SelectClass";
            SelectClass.Size = new Size(126, 26);
            SelectClass.TabIndex = 2;
            SelectClass.Text = "Select Class:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 10.8F);
            textBox1.Location = new Point(398, 80);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 29);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 10.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bodybuilding", "Kickboxing", "Yoga" });
            comboBox1.Location = new Point(398, 142);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 30);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MintCream;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 274);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(637, 229);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__6_1;
            ClientSize = new Size(850, 564);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(SelectClass);
            Controls.Add(UserName);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label UserName;
        private Label SelectClass;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}