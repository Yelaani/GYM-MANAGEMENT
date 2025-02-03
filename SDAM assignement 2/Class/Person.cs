using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace SDAM_assignement_2.Class
{
    internal class Person
    {
        public class NewMember
        {
            private string firstName;
            private string lastName;
            private string gender;
            private DateTime dateOfBirth;
            private string telephoneNumber;
            private string address;


            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string Gender
            {
                get { return gender; }
                set { gender = value; }
            }

            public DateTime DateOfBirth
            {
                get { return dateOfBirth; }
                set { dateOfBirth = value; }
            }

            public string TelephoneNumber
            {
                get { return telephoneNumber; }
                set { telephoneNumber = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }



        }




    }
}
