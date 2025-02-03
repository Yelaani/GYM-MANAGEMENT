using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM_assignement_2.Class
{
    internal class ClassController
    {
        

        private readonly Database _database;

        public ClassController()
        {
            _database = new Database();
        }
        
        public bool DeleteClassFromSchedule(string className)
        {
            return _database.DeleteClass(className);  
        }

        public void UpdateClass(ClassV classObj)
        {
            // Validate if all fields are filled
            if (string.IsNullOrWhiteSpace(classObj.ClassName) ||
                string.IsNullOrWhiteSpace(classObj.Date) ||
                string.IsNullOrWhiteSpace(classObj.Time) ||
                string.IsNullOrWhiteSpace(classObj.Capacity))
            {
                MessageBox.Show("All fields must be filled before updating the class.");
                return; 
            }

            
            List<string> setClauses = new List<string>
    {
        $"Date = '{classObj.Date}'",
        $"Time = '{classObj.Time}'",
        $"Capacity = '{classObj.Capacity}'"
    };

            string condition = $"ClassName = '{classObj.ClassName}'";

            _database.UpdateClass("classSchedule", setClauses, condition);
        }









        public DataTable GetClassSchedule()
        {
            return _database.GetClass();
        }
    }
}
