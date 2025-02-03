using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace SDAM_assignement_2.Class

{
    internal class Database
    {
        private MySqlConnection _connection;
        private string connectionString = "Server=localhost;Database=gym;User ID=root;Password=";

        public Database()
        {
            _connection = new MySqlConnection(connectionString);
        }

        private void ExecuteQuery(string query)
        {
            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                _connection.Close();
            }
        }
        public bool ValidateCredentials(string Username, string Password, string tableName)
        {
            try
            {
                _connection.Open();
                string query = $"SELECT username, password FROM {tableName} WHERE username = @Username";

                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    
                    command.Parameters.AddWithValue("@Username", Username);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["Password"].ToString();

                            if (Password == storedPassword)
                            {
                                return true; 
                            }
                            else
                            {
                                MessageBox.Show("Password mismatch. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public void ATinsert(string table, List<string> columns, List<object> values)
        {
            if (columns.Count != values.Count)
            {
                throw new ArgumentException("The number of columns and values must match");
            }
            string columnsJoined = string.Join(",", columns.ConvertAll(c => $"`{c}`"));

            string parameters = string.Join(",", values.ConvertAll(v => $"'{v.ToString().Replace("'", "''")}'"));

            string query = $"INSERT INTO {table} ({columnsJoined}) VALUES ({parameters})";

            ExecuteQuery(query);
        }
        public void Insert(string table, List<string> columns, List<object> values)
        {
            if (columns.Count != values.Count)
            {
                throw new ArgumentException("The number of columns and values must match");
            }
            string columnsJoined = string.Join(",", columns.ConvertAll(c => $"`{c}`"));

            string parameters = string.Join(",", values.ConvertAll(v => $"'{v.ToString().Replace("'", "''")}'"));

            string query = $"INSERT INTO {table} ({columnsJoined}) VALUES ({parameters})";
            ExecuteQuery(query);
        }

        public void UpdateTrainer(string trainer, List<string> setClauses, string condition)
        {
            string setClausesJoined = string.Join(",", setClauses);
            string query = $"UPDATE {trainer} SET {setClausesJoined} WHERE {condition}";
            ExecuteQuery(query);
        }

        public void Delete(string table, string condition)
        {
            string query = $"DELETE FROM {table} WHERE condition={condition}";
            ExecuteQuery(query);
        }

        public bool DeleteTrainer(string username)
        {
            string query = $"DELETE FROM trainer WHERE Username='{username}'";
            ExecuteQuery(query);


            
            return true;
        }
        public DataTable GetTable(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetTrainerPayments()
        {
            string query = "SELECT * FROM trainer_payments";
            using (var connection = new MySqlConnection("Server=localhost;Database=gym;User ID=root;Password="))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                using (var adapter = new MySqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public void UpdateMember(string trainer, List<string> setClauses, string condition)
        {
            string setClausesJoined = string.Join(",", setClauses);
            string query = $"UPDATE {trainer} SET {setClausesJoined} WHERE {condition}";
            ExecuteQuery(query);
        }

        public bool DeleteMember(string username)
        {
            string query = $"DELETE FROM member WHERE Username='{username}'";
            ExecuteQuery(query);


            
            return true;
        }
        public DataTable GetTrainers()
        {
            string query = "SELECT * FROM trainer";

            DataTable dt = new DataTable();

            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                _connection.Close();
            }

            return dt;
        }

        public DataTable GetMember()
        {
            string query = "SELECT * FROM trainer";

            DataTable dt = new DataTable();

            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                _connection.Close();
            }

            return dt;
        }
        public DataTable Payment()
        {
            string query = "SELECT * FROM payment";

            DataTable dt = new DataTable();

            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                _connection.Close();
            }

            return dt;
        }


        public DataTable Getapayments()
        {
            string query = "SELECT * FROM trainer_payments";

            DataTable dt = new DataTable();

            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                _connection.Close();
            }

            return dt;
        }

        public DataTable Traineravailabe()
        {
            string query = "SELECT * FROM availability";
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }

            return dt;
        }

        public DataTable GetClass()
        {
            string query = "SELECT * FROM classschedule";
            return GetTable(query);


            DataTable dt = new DataTable();

            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                _connection.Close();
            }

            return dt;
        }


        public List<Dictionary<string, string>> Select(string table, string columns = "*", string condition = "")
        {
            string query = $"SELECT {columns} FROM {table}" + (string.IsNullOrEmpty(condition) ? "" : $" WHERE {condition}");
            return ExecuteReader(query);
        }

        private List<Dictionary<string, string>> ExecuteReader(string query)
        {
            var result = new List<Dictionary<string, string>>();

            try
            {
                _connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetName(i), reader[i].ToString());
                        }
                        result.Add(row);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
        public DataTable GetData(string table)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM class";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public bool DeleteClass(string className)
        {
            try
            {
                _connection.Open();
                string query = "DELETE FROM classSchedule WHERE ClassName = @ClassName";

                using (MySqlCommand cmd = new MySqlCommand(query, _connection))
                {
                    
                    cmd.Parameters.AddWithValue("@ClassName", className);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        public void UpdateClass(string table, List<string> setClauses, string condition)
        {
            string setClausesJoined = string.Join(",", setClauses);
            string query = $"UPDATE {table} SET {setClausesJoined} WHERE {condition}";
            ExecuteQuery(query);
        }



    }
}
