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
    public partial class Memberattendance : Form
    {
        private Trainercontroller trainerController = new Trainercontroller();
        public Memberattendance()
        {
            InitializeComponent();
            trainerController = new Trainercontroller();
            GetTable();
        }
        private void GetTable()
        {
            trainerController.DisplayAttendance(dataGridView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Memberattendance_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string memberName = User.Text;
                string className = comboBox1.SelectedItem?.ToString() ?? string.Empty;
                string date = Date.Text;
                string time = Time.Text;
                string attendance = "";
                if (Present.Checked)
                {
                    attendance = Present.Text;
                }
                else if (Absent.Checked)
                {
                    attendance = Absent.Text;
                }
                else
                {
                    attendance = "";
                    return;
                }

                if (string.IsNullOrWhiteSpace(memberName) || string.IsNullOrWhiteSpace(className) ||
                    string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(time))
                {
                    MessageBox.Show("All fields must be filled!");
                    return;
                }
          
                
                    
                
                                
              MessageBox.Show("User details updated successfully!");
                

                trainerController.InsertAttendance(memberName, className, date, time, attendance);
                GetTable();

                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetTable();
        }
    }
}
