using MySql.Data.MySqlClient;
using SDAM_assignement_2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SDAM_assignement_2.Forms
{
    public partial class Register : Form

    {
        private Membercontroller controller;
        public Register()
        {
            InitializeComponent();
            controller = new Membercontroller();
            PopulateComboBox();
            LoadRegisterData();
        }



        private void PopulateComboBox()
        {

        }
        private void LoadRegisterData()
        {

            dataGridView1.DataSource = controller.GetRegisteredUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string className = comboBox1.SelectedItem?.ToString();

            // Ensure that the user has selected a class and entered a valid username
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter a username and select a class.");
                return;
            }

            try
            {
                // MySQL connection string
                string connectionString = "Server=localhost;Database=gym;Uid=root;Pwd=;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Step 1: Get the capacity of the selected class from classSchedule
                    string getCapacityQuery = "SELECT Capacity FROM classSchedule WHERE ClassName = @ClassName";
                    int classCapacity = 0;
                    using (MySqlCommand cmd = new MySqlCommand(getCapacityQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClassName", className);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            classCapacity = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Class not found.");
                            return;
                        }
                    }

                    // Step 2: Count the number of users already registered for the selected class
                    string countRegisteredUsersQuery = "SELECT COUNT(*) FROM class WHERE SelectClass = @ClassName";
                    int registeredUsers = 0;
                    using (MySqlCommand cmd = new MySqlCommand(countRegisteredUsersQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClassName", className);
                        registeredUsers = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Step 3: Compare registered users with class capacity
                    if (registeredUsers >= classCapacity)
                    {
                        MessageBox.Show("Class capacity exceeded. Cannot add more users.");
                        return;
                    }

                    // Step 4: Proceed with registration if capacity is not exceeded
                    string insertQuery = "INSERT INTO class (UserName, SelectClass) VALUES (@UserName, @ClassName)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@ClassName", className);

                        // Execute the query
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("You have successfully registered for the class.");
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        //controller.RegisterUser(userName, className);
        //    LoadRegisterData();
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadRegisterData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}