namespace SDAM_assignement_2.Forms
{
    partial class AdminClass
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
            createClass = new Button();
            editClass = new Button();
            deleteClass = new Button();
            SuspendLayout();
            // 
            // createClass
            // 
            createClass.BackColor = Color.LightSteelBlue;
            createClass.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            createClass.Location = new Point(82, 143);
            createClass.Name = "createClass";
            createClass.Size = new Size(197, 111);
            createClass.TabIndex = 0;
            createClass.Text = "CREATE NEW CLASS";
            createClass.UseVisualStyleBackColor = false;
            createClass.Click += createClass_Click;
            // 
            // editClass
            // 
            editClass.BackColor = SystemColors.InactiveCaption;
            editClass.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            editClass.Location = new Point(292, 143);
            editClass.Name = "editClass";
            editClass.Size = new Size(197, 111);
            editClass.TabIndex = 1;
            editClass.Text = "UPDATE EXISTING CLASS";
            editClass.UseVisualStyleBackColor = false;
            editClass.Click += editClass_Click;
            // 
            // deleteClass
            // 
            deleteClass.BackColor = SystemColors.ActiveBorder;
            deleteClass.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            deleteClass.Location = new Point(502, 143);
            deleteClass.Name = "deleteClass";
            deleteClass.Size = new Size(197, 111);
            deleteClass.TabIndex = 2;
            deleteClass.Text = "DELETE CLASS";
            deleteClass.UseVisualStyleBackColor = false;
            deleteClass.Click += deleteClass_Click;
            // 
            // AdminClass
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__23_;
            ClientSize = new Size(789, 450);
            Controls.Add(deleteClass);
            Controls.Add(editClass);
            Controls.Add(createClass);
            Name = "AdminClass";
            Text = "AdminClass";
            Load += AdminClass_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button createClass;
        private Button editClass;
        private Button deleteClass;
    }
}