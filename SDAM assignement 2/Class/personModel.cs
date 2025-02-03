using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace SDAM_assignement_2.Class
{
    internal class personModel
    {
        private Database database;

        public personModel()
        {
            database = new Database();
        }
        public bool createUser(string tableName, string fname, string lname, string gender, string dob, string mobile, string address,string Username,string Password)
        {
            var columns = new List<string> {"FirstName", "LastName","Gender", "DOB", "Telephone num", "Address","Username","Password" };
            var values = new List<object>
                {
                fname,
                lname,
                gender,
                dob,
                mobile,
                address,
                Username,
                Password,
               
                };

            database.Insert(tableName, columns, values);
            return true;

        }


    }
}
