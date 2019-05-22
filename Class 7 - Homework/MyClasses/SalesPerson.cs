using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class SalesPerson : Employee
    {
        private double successSaleRevenue;

        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 500;
            RoleOfEmployee = Role.Sales;
        }

        public void AddSuccessRevenue(int succes)
        {
            successSaleRevenue = succes;
        }

        public override double GetSalary()
        {
            if (successSaleRevenue <= 2000)
            {
                Salary += 500;
            }
            if (successSaleRevenue > 2000 && successSaleRevenue <= 5000)
            {
                Salary += 1000;
            }
            if (successSaleRevenue > 5000)
            {
                Salary += 1500;
            }
            return Salary;
        }
    }
}
