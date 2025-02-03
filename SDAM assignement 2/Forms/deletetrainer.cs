using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class deletetrainer : Form
    {
        private Trainercontroller trainer;

        public deletetrainer()
        {
            InitializeComponent();
            trainer = new Trainercontroller(); // Initialize Trainer class
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = useT.Text.Trim(); // Assume 'useT' is the TextBox for username input

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete {username}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = trainer.DeleteTrainer(username);


                    if (isDeleted)
                    {
                        MessageBox.Show("Trainer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh DataGridView after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete trainer. Ensure the username is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting trainer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Load trainers into DataGridView
        private void LoadData()
        {
            try
            {
                DataTable trainersTable = trainer.GetTrainers(); // Fetch trainers
                dataGridView1.DataSource = trainersTable; // Bind data to DataGridView


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                useT.Text = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString(); // Auto-fill username field
            }

        }

        private void deletetrainer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for DataGridView cell click
    }
}

