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
    public partial class AdminClass : Form
    {
        public AdminClass()
        {
            InitializeComponent();
        }

        private void createClass_Click(object sender, EventArgs e)
        {
            ClassSchedule classSchedule = new ClassSchedule();
            classSchedule.Show();
        }

        private void deleteClass_Click(object sender, EventArgs e)
        {
            DeleteClass deleteClass = new DeleteClass();
            deleteClass.Show();
        }

        private void editClass_Click(object sender, EventArgs e)
        {
            UpdateClass updateClass = new UpdateClass();
            updateClass.Show();
        }

        private void AdminClass_Load(object sender, EventArgs e)
        {

        }
    }
}
