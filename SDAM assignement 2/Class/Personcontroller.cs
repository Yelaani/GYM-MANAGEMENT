using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SDAM_assignement_2.Class
{
    internal class Personcontroller
    {
        private string connectionString = "server=localhost;user=root;password=;database=gym;";


        private readonly personModel model;

        public Personcontroller()
        {
            model = new personModel();
        }
        public string AddPerson(string tableName, string fName, string LName, string gender, string dob, string mobile, string address, string Username, string Password)
        {
            // Validate First Name and Last Name
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(LName))
            {
                return "First name and last name cannot be empty.";
            }

            // Validate Gender
            if (string.IsNullOrEmpty(gender))
            {
                return "Gender is not selected.";
            }

            // Validate Date of Birth
            if (!DateTime.TryParse(dob, out DateTime dateOfBirth))
            {
                return "Invalid date of birth format.";
            }
            else
            {
                var age = DateTime.Now.Year - dateOfBirth.Year;
                if (dateOfBirth > DateTime.Now.AddYears(-age)) age--; 
                if (age < 10)
                {
                    return "Date of birth indicates age is less than 10 years. Please enter a valid date.";
                }
            }
            // Validate Telephone Number
            if (string.IsNullOrEmpty(mobile) || mobile.Length != 9 || !int.TryParse(mobile, out _))
            {
                return "Telephone number must be exactly 9 digits and numeric.";
            }
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                return "Username or password cannot be empty.";
            }

            model.createUser(tableName, fName, LName, gender, dob, mobile, address, Username, Password);

            // If all validations pass, return success message
            return $"Person added successfully to {tableName}: {fName} {LName}, {gender}, DOB: {dob}, Mobile: {mobile}, Address: {address},Username: {Username},Password{Password}";
        }

        public string DeleteMember(string username)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM member WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return "Member deleted successfully.";
                        }
                        else
                        {
                            return "Member not found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }

}