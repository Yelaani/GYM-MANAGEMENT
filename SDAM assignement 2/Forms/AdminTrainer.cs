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
    public partial class AdminTrainer : Form
    {
        private Database data;

        public AdminTrainer()
        {
            InitializeComponent();
            data = new Database();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NewTrainer newTrainer = new NewTrainer();
            newTrainer.Show();
            this.Close();
        }

        private void AdminTrainer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            deletetrainer deletetrainer = new deletetrainer();
            deletetrainer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Updatetrainer updatetrainer = new Updatetrainer();
            updatetrainer.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NewTrainer trainer = new NewTrainer();
            trainer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Trainerpayments trainerpayments = new Trainerpayments();
            trainerpayments.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable available = data.Traineravailabe();
            dataGridView1.DataSource = available;

        }
    }
}
