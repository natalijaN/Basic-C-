using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role RoleOfEmployee { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {

        }

        public double GetSalaryOfEmployee(double setSalary)
        {
            return Salary = setSalary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}  ");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }


        public enum Role
        {
            Sales = 1,
            Manager,
            Other
        }

    }
}
