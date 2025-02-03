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
    public partial class DeleteMember : Form
    {
        private Membercontroller member;
        public DeleteMember()
        {
            InitializeComponent();
            member = new Membercontroller(); 
            LoadData();
        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim(); 

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
                    bool isDeleted = member.DeleteMember(username);


                    if (isDeleted)
                    {
                        MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); 
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete member. Ensure the username is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Load trainers into DataGridView
        private void LoadData()
        {
            try
            {
                DataTable memberTable = member.GetMember(); 
                dataGridView1.DataSource = memberTable;


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
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString(); // Auto-fill username field
            }

        }

        private void deletetrainer_Load(object sender, EventArgs e)
        {

        }

        // Event handler for DataGridView cell click
    }
}

