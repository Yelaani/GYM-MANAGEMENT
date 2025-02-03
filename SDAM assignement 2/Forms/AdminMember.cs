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

namespace SDAM_assignement_2.Forms
{
    public partial class AdminMember : Form
    {
        private Database database;
        public AdminMember()
        {
            InitializeComponent();
            database = new Database();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewMember newMember = new NewMember();
            newMember.Show();
            this.Close();
        }
        private void AdminMember_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateMember updateForm = new UpdateMember();
            updateForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteMember deleteMemberForm = new DeleteMember();
            deleteMemberForm.Show();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable table = database.Payment();
            dataGridView.DataSource = table;
        }


        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM class";

            string connectionString = "Server=localhost;Database=gym;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
