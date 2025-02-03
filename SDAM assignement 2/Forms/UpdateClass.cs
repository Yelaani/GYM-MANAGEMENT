using MySql.Data.MySqlClient;
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
    public partial class UpdateClass : Form

    {
        private ClassController classController;

        public UpdateClass()
        {
            InitializeComponent();
            classController = new ClassController();
            clsShow();
        }

        private void clsShow()
        {
            DataTable dataTable = classController.GetClassSchedule();
            dataGridView1.DataSource = dataTable;
        }
        private void UpdateClass_Load(object sender, EventArgs e)
        {
            LoadClassData();
        }
        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            ClassV classObj = new ClassV
            {
                ClassName = textBox1.Text.Trim(),
                Date = textBox2.Text.Trim(),
                Time = textBox3.Text.Trim(),
                Capacity = textBox4.Text.Trim()
            };

            classController.UpdateClass(classObj);

            MessageBox.Show("Class details updated successfully!");
        }

        //private void LoadClassData()
        //{
        //    //string connectionString = "server=localhost;user=root;password=;database=gym;";
        //    //string query = "SELECT * FROM classschedule"; 

        //    //using (MySqlConnection conn = new MySqlConnection(connectionString))
        //    //{
        //    //    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
        //    //    DataTable dataTable = new DataTable();
        //    //    adapter.Fill(dataTable);

        //    //    // Binding the data to DataGridView
        //    //    dataGridView1.DataSource = dataTable;
        //    //}

        //    dataGridView1.DataSource = controller.GetClassSchedule();



        //}

        private void LoadClassData()
        {
            try
            {
                // Fetch the class schedule data and bind it to the DataGridView
                dataGridView1.DataSource = classController.GetClassSchedule();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading class data: " + ex.Message);
            }
        }

        private void UpdateClass_Load_1(object sender, EventArgs e)
        {

        }
    }
}
