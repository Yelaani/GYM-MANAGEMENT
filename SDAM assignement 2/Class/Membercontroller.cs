using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SDAM_assignement_2.Class
{
    internal class Membercontroller:Personcontroller
    {

        private readonly Database _database;
        private Database db = new Database();


        public Membercontroller()
        {
            db = new Database();
            _database = new Database();
        }
        public bool Validate(string Username, string Password)
        {


            return true;
         }

        // New method to add members
        public string AddMember(string fName, string lName, string gender, string dob, string mobile, string address, string username, string password)
        {
            Personcontroller personController = new Personcontroller();
            return personController.AddPerson("member", fName, lName, gender, dob, mobile, address, username, password);
        }
        public void UpdateMember(MemberV member)
        {
            List<string> columns = new List<string> { "Telephonenum", "Password", "Address" };
            List<string> setClauses = new List<string>
        {
            $"Telephonenum= '{member.Phone}'",
            $"Password = '{member.Password}'",
            $"Address = '{member.Address}'"
        };

            string condition = $"Username = '{member.Username}'";

            db.UpdateMember("member", setClauses, condition);
        }
        public bool DeleteMember(string username)
        {
            return _database.DeleteMember(username); 
        }

        // Fetch trainers as a DataTable
        public DataTable GetMember()
        {
            return _database.GetMember(); 
        }


        public DataTable LoadMemberData()
        {
            return db.GetMember();
        }
        public void RegisterUser(string userName, string className)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(className))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<string> columns = new List<string> { "UserName", "SelectClass" };
                List<object> values = new List<object> { userName, className };

                db.Insert("class", columns, values);
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable GetRegisteredUsers()
        {
            return db.GetData("register");
        }


    }
}

