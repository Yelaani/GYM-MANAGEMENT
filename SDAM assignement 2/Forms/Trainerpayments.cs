using Mysqlx.Datatypes;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SDAM_assignement_2.Forms
{

    public partial class Trainerpayments : Form
    {
        private Trainercontroller control = new Trainercontroller();
        

        public Trainerpayments()
        {
            InitializeComponent();
            control = new Trainercontroller();
            LoadPayments();


        }
        private void LoadPayments()
        {
            DataTable dataTable = control.Loadpayments();
            dataGridView1.DataSource = dataTable;
        }



        private const decimal Salary = 30000;



        private void button1_Click(object sender, EventArgs e)
        {
            string trainerName = trname.Text;
            DateTime paymentDate = Date.Value;

            if (string.IsNullOrEmpty(trainerName))
            {
                MessageBox.Show("Please fill all fields.;");

            }

                if (paymentDate > DateTime.Now)
            {
                Trainercontroller controller = new Trainercontroller();
                controller.ProcessPayment(trainerName, paymentDate, Salary);
                MessageBox.Show("Payment record inserted successfully.");
                LoadPayments();
            }
            else
            {
                MessageBox.Show("Please select a future date.");
            }

        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadPayments();
        }
    }


}


