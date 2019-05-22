using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5____Homework.Classes
{
   public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public int SecurityNumber;
        public bool BuyerCart;
 

        public Person(string firstName, string lastName, DateTime dateOfBirth, int securityNumber, bool buyerCart)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            SecurityNumber = securityNumber;
            BuyerCart = buyerCart;
        }
        public Person()
        {

        }
    }
}
