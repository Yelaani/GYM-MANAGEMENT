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
    public partial class DeleteClass : Form
    {
        private ClassController controller;

        public DeleteClass()
        {
            InitializeComponent();
            controller = new ClassController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string className = textBox1.Text.Trim(); // Assuming txtClassName is a TextBox for class name

            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter a class name.");
                return;
            }

            bool isDeleted = controller.DeleteClassFromSchedule(className);

            if (isDeleted)
            {
                MessageBox.Show("Class deleted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to delete class. Please check if the class name is correct.");
            }
        }
    }
}
