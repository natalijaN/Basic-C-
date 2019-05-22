using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            RoleOfEmployee = Role.Manager;
            Salary = salary;
        }

        public Manager()
        {

        }

        public double AddBonus(double bonus)
        {
            return Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
