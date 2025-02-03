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
    public partial class NewTrainer : Form
    {
        public NewTrainer()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fName = fname.Text;
                string LName = Lname.Text;
                string gender = "";

                // Check Gender
                if (Male.Checked)
                {
                    gender = Male.Text;
                }
                else if (Female.Checked)
                {
                    gender = Female.Text;
                }
                else
                {
                    gender = "";
                    return;
                }

                string dob = DOB.Text;
                string mobile = tele.Text;
                string addressText = address.Text;
                string Username = Nuser.Text;
                string Password = Npass.Text;

                if (string.IsNullOrWhiteSpace(Password))
                {
                    MessageBox.Show("Password cannot be empty.");
                    return;
                }

                Personcontroller control = new Personcontroller();
                string result = control.AddPerson("trainer", fName, LName, gender, dob, mobile, addressText, Username, Password);


                MessageBox.Show(result);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

            fname.Text = string.Empty;
            Lname.Text = string.Empty;
            Male.Checked = false;
            Female.Checked = false;
            DOB.Value = DateTime.Now;
            tele.Text = string.Empty;
            address.Text = string.Empty;
            Nuser.Text = string.Empty;
            Npass.Text = string.Empty;



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NewTrainer_Load(object sender, EventArgs e)
        {

        }
    }
}
