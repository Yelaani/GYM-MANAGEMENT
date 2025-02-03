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
    public partial class Admindashboard : Form
    {
        public Admindashboard()
        {
            InitializeComponent();
        }

        private void memberbtn_Click(object sender, EventArgs e)
        {
            AdminMember adminMember = new AdminMember();
            adminMember.Show();
        }

        private void trainerbtn_Click(object sender, EventArgs e)
        {
            AdminTrainer adminTrainer = new AdminTrainer();
            adminTrainer.Show();
        }


        private void Admindashboard_Load(object sender, EventArgs e)
        {

        }

        private void classbtn_Click_1(object sender, EventArgs e)
        {
            AdminClass adminClass = new AdminClass();
            adminClass.Show();
        }
    }
}
