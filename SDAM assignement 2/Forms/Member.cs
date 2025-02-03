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

namespace SDAM_assignement_2.Forms
{
    public partial class Member : Form
    {
        private Membercontroller Membercontroller;
        public Member()
        {
            InitializeComponent();
            Membercontroller = new Membercontroller();
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
                bool isValid = db.ValidateCredentials(Username, Password, "member");

                if (isValid)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Redirect to the main form
                    Memberdashboard mainForm = new Memberdashboard();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();

                    this.Close();

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

        private void Member_Load(object sender, EventArgs e)
        {

        }
    }
}

