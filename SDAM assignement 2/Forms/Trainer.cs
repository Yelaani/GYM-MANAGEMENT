using SDAM_assignement_2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SDAM_assignement_2.Forms
{
    public partial class Trainer : Form
    {
        private readonly TrainerV Tr;

        public Trainer()
        {
            InitializeComponent();
            Tr = new TrainerV();
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Username = username.Text;
                string Password = password.Text;


                Database db = new Database();
                bool isValid = db.ValidateCredentials(Username, Password, "trainer");

                if (isValid)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Redirect to the main form
                    Trainerdashboard mainForm = new Trainerdashboard();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();

                    this.Close();

                }

                else
                {
                    MessageBox.Show("Username not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return;
            }

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Trainer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
