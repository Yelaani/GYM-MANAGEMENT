using MySql.Data.MySqlClient;
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
    public partial class ClassSchedule : Form
    {
        public ClassSchedule()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input from form fields
                string className = textBox1.Text;
                string date = textBox2.Text;
                string time = textBox3.Text;
                string trainer = textBox4.Text;
                string capacityStr = textBox5.Text;

                if (string.IsNullOrWhiteSpace(className) || string.IsNullOrWhiteSpace(date) ||
                string.IsNullOrWhiteSpace(time) || string.IsNullOrWhiteSpace(trainer) || string.IsNullOrWhiteSpace(capacityStr))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                int capacity;
                bool isCapacityValid = int.TryParse(capacityStr, out capacity);

                if (!isCapacityValid || capacity <= 0)
                {
                    MessageBox.Show("Capacity must be a positive integer.");
                    return;
                }

                DateTime parsedDate;
                string format = "ddMMyy"; // DDMMYY format
                bool isValidDate = DateTime.TryParseExact(date, format, null, System.Globalization.DateTimeStyles.None, out parsedDate);

                if (!isValidDate)
                {
                    MessageBox.Show("Invalid date format. Please use DDMMYY format.");
                    return;
                }

                // MySQL connection string
                string connectionString = "Server=localhost;Database=gym;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string checkRegisteredUsersQuery = "SELECT COUNT(*) FROM classschedule WHERE ClassName = @ClassName";
                    using (MySqlCommand cmdCheck = new MySqlCommand(checkRegisteredUsersQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@ClassName", className);

                        // Execute the query to count registered users
                        int registeredUsers = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        // Compare the number of registered users with the class capacity
                        if (registeredUsers >= capacity)
                        {
                            MessageBox.Show("Class capacity exceeded. Cannot add more users.");
                            return;
                        }
                    }

                    // Insert query
                    string insertQuery = "INSERT INTO classSchedule (ClassName, Date, Time, Trainer, Capacity) " +
                                   "VALUES (@ClassName, @Date, @Time, @Trainer, @Capacity)";

                    // Create a MySQL command
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClassName", className);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Time", time);
                        cmd.Parameters.AddWithValue("@Trainer", trainer);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);

                        // Execute the query
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Class schedule added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add class schedule.");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
