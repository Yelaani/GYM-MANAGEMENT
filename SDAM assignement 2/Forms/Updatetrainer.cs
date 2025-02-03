using SDAM_assignement_2.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace SDAM_assignement_2.Forms
{
    public partial class Updatetrainer : Form
    {
        private Trainercontroller Controller = new Trainercontroller();

        public Updatetrainer()
        {
            InitializeComponent();
            Controller = new Trainercontroller();
            LoadTrainers();
        }

        private void LoadTrainers()
        {
            DataTable dataTable = Controller.LoadTrainerData();
            dataGridView1.DataSource = dataTable;
        }

        private void Updatetrainer_Load(object sender, EventArgs e)
        {
            // Any required actions on form load can be placed here.
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                TrainerV traine = new TrainerV
                {
                    Username = txtUsername.Text,
                    Phone = txtPhone.Text,
                    Password = txtPassword.Text,
                    Address = txtAddress.Text
                };

                Controller.UpdateTrainer(traine);
                MessageBox.Show("Trainer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTrainers(); // Refresh table
            }
            else
            {
                MessageBox.Show("Please select a trainer first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["username"].Value?.ToString();
                txtPhone.Text = row.Cells["phone"].Value?.ToString();
                txtPassword.Text = row.Cells["password"].Value?.ToString();
                txtAddress.Text = row.Cells["address"].Value?.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
