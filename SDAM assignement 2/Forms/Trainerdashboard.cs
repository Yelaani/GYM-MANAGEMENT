using MySql.Data.MySqlClient;
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
    public partial class Trainerdashboard : Form
    {
        private Database data;
        public Trainerdashboard()
        {
            InitializeComponent();
            data = new Database();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Memberattendance memberattendance = new Memberattendance();
            memberattendance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ClassSchedule";

            string connectionString = "Server=localhost;Database=gym;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Traineravaillability traineravaillability = new Traineravaillability();
            traineravaillability.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable paymentsData = data.Getapayments();
            dataGridView1.DataSource = paymentsData;

        }
    }
}
