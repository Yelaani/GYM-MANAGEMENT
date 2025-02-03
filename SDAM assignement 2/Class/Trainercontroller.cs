using SDAM_assignement_2.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM_assignement_2.Class
{
    internal class Trainercontroller : Personcontroller
    {
        private readonly Database _database;
        private Database db = new Database();
        private readonly Trainerpayments _view;
        private const int HardCodedSalary = 20000;
        private DataGridView dataGridView;



        public Trainercontroller()
        {
            db= new Database();
            _database = new Database();
            dataGridView = new DataGridView();
        }

        public Trainercontroller(DataGridView dgv)
        {
            dataGridView = dgv;
        }


        public bool Validate(string Username, string Password)
        {


            return true;
        }

        // New method to add trainers
        public string AddMember(string fName, string lName, string gender, string dob, string mobile, string address, string username, string password)
        {
            Personcontroller personController = new Personcontroller();
            return personController.AddPerson("member", fName, lName, gender, dob, mobile, address, username, password);
        }
        public void UpdateTrainer(TrainerV trainer)
        {
            List<string> columns = new List<string> { "Telephonenum", "Password","Address" };
            List<string> setClauses = new List<string>
        {
            $"Telephonenum= '{trainer.Phone}'",
            $"Password = '{trainer.Password}'",
            $"Address = '{trainer.Address}'"
        };

            string condition = $"Username = '{trainer.Username}'";

            db.UpdateTrainer("trainer", setClauses, condition);
        }
        public bool DeleteTrainer(string username)
        {
            return _database.DeleteTrainer(username); 
        }

        // Fetch trainers as a DataTable
        public DataTable GetTrainers()
        {
            return _database.GetTrainers(); 
        }


        public DataTable LoadTrainerData()
        {
            return db.GetTrainers();
        }
        public void InsertAttendance(string memberName, string className, string date, string time, string attendance)
        {
            List<string> columns = new List<string> { "MemberName", "ClassName", "Date", "Time", "Attendance" };
            List<object> values = new List<object> { memberName, className, date, time, attendance };
            db.ATinsert("attendance", columns, values);
        }

        public void DisplayAttendance(DataGridView dataGridView)
        {
            string query = "SELECT * FROM attendance";
            DataTable table = db.GetTable(query);
            dataGridView.DataSource = table;
        }

        public void ProcessPayment(string trainerName, DateTime paymentDate, decimal salary)
        {
            string table = "trainer_payments";
            List<string> columns = new List<string> { "trainer_name", "payment_date", "Salary(Rs.)" };
            List<object> values = new List<object> { trainerName, paymentDate.ToString("yyyy-MM-dd"), salary };

            try
            {
                db.Insert(table, columns, values);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public DataTable Loadpayments()
        {
            return db.Getapayments();
        }
        public void ConfirmTrainerAvailability(string tr_username, DateTime date, string tr_time, string classname)
        {




            try
            {
                if (string.IsNullOrWhiteSpace(tr_username) || string.IsNullOrWhiteSpace(tr_time))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (date <= DateTime.Now)
                {
                    MessageBox.Show("Please select a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                List<string> columns = new List<string> { "Username", "Date", "Time", "Class" };
                List<object> values = new List<object> { tr_username, date.ToString("yyyy-MM-dd"), tr_time, classname };
                db.Insert("availability", columns, values);
                MessageBox.Show("Trainer availability confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                traineravailabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataTable traineravailabe()
        {
            return _database.Traineravailabe();
        }

    }
}

  