using MySql.Data.MySqlClient;
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
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }


        private void UpdateMember_Load(object sender, EventArgs e)
        {
            LoadMemberData();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }


        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=gym;";
            string query = "UPDATE member SET `Telephone num` = @Telephone, Password = @Password WHERE Username = @Username";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telephone", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", textBox3.Text.Trim());

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User details updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Username not found.");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadMemberData()
        {
            string connectionString = "server=localhost;user=root;password=;database=gym;";
            string query = "SELECT * FROM member"; // Fetch all members, adjust query if you need specific columns

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;  // Bind the DataTable to the DataGridView
                }
            }
        }

    }
}
