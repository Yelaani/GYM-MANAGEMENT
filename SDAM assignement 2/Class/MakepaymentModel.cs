using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAM_assignement_2.Class
{
    internal class MakepaymentModel
    {
        private Database db;

        public MakepaymentModel()
        {
            db = new Database();
        }
        public bool MakePayment(string username, int months, decimal totalAmount)
        {
            var columns = new List<string> { "Username", "Total", "Months" };
            var values = new List<object>
                {
               username,
              totalAmount,
               months,


                };

            db.Insert("payment", columns, values);
            return true;

        }
    }
}
