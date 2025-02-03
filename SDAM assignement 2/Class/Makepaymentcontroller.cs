using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SDAM_assignement_2.Class
{
    public class Makepaymentcontroller
    {

        private MakepaymentModel makepaymentModel;

        public Makepaymentcontroller()
        {
            makepaymentModel = new MakepaymentModel();
        }

        public bool MakePayment(string username, int months, decimal totalAmount)
        {

           bool isSuccess= makepaymentModel.MakePayment(username, months, totalAmount);
            if (isSuccess) {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}