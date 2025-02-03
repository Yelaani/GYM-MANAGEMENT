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
    public partial class Admin : Form
    {
        private const string AdminUsername = "admin123";
        private const string AdminPassword = "pw123";

        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateAdmin(string username, string password)
        {
            return username == AdminUsername && password == AdminPassword;
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            string UsernameInput= username.Text;
            string PasswordInput= password.Text;

            if (ValidateAdmin(UsernameInput, PasswordInput))
            {
                MessageBox.Show("Login successful!");

                this.Hide();

                Admindashboard adminDashboard= new Admindashboard();
                adminDashboard.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username  or password");
            }
        }
    }
}
