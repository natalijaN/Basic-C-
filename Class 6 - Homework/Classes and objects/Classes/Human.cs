using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects.Classes
{
    public class Human
    {

        public string FirstName;
        public string LastName;
        private string SSN;

        public void Maticen()
        {
            Console.WriteLine(SSN);
        }

        public Human(string first)
        {
            FirstName = first;
        }
        public Human()
        {

        }
    }
}
