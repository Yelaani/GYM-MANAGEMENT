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
    public partial class Traineravaillability : Form
    {
        private Trainercontroller trainerController;
        public Traineravaillability()
        {
            InitializeComponent();
            trainerController = new Trainercontroller();
            tr_ava();



        }
        private void tr_ava()
        {
            DataTable dataTable = trainerController.traineravailabe();
            dataGridView1.DataSource = dataTable;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string tr_username = tr_user.Text.Trim(); // Ensure no leading/trailing spaces
            DateTime selectedDate = dateTimePicker1.Value;
            string tr_time = date1.Text.Trim();
            string classname = classtype.SelectedItem?.ToString();


            Trainercontroller tr = new Trainercontroller();
            tr.ConfirmTrainerAvailability(tr_username, selectedDate, tr_time, classname);
            tr_ava();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Traineravaillability_Load(object sender, EventArgs e)
        {

        }
    }
}
