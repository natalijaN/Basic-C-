using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Create a class library project and in it create all classes
            //Create a class called Employee with the following properties:
            //    FirstName
            //    LastName
            //    Role - Enum {Sales, Manager, Other }
            //    Salary - protected, double
            //Create two methods:
            //    PrintInfo = Prints FirstName, LastName and Salary
            //    GetSalary - returns the salary


            Console.WriteLine("------MANAGER------");

            Manager manager = new Manager("Marija", "Filipovska", 4500);

            manager.AddBonus(4000);

            Console.WriteLine($"The manager {manager.FirstName}, has salary: {manager.GetSalary()}$");


            Console.WriteLine("------SALES PERSON------");

            SalesPerson salePerson = new SalesPerson("David", "Stojanovski");


            salePerson.GetSalary();

            salePerson.AddSuccessRevenue(2000);

            Console.WriteLine($"Sale Person {salePerson.FirstName}, has salary: {salePerson.GetSalary()}$ ");

            Console.WriteLine("------OTHER------");


            Employee employee = new Employee();

            employee.FirstName = "John";
            employee.LastName = "Doe";
            employee.RoleOfEmployee = Employee.Role.Other;
            var salaryOfEmployee = employee.GetSalaryOfEmployee(300);

            Console.WriteLine($"The salary of {employee.FirstName}, with role: {employee.RoleOfEmployee}, has salary: {salaryOfEmployee}$  ");
            // Without using method for setting Salary in class Employee, Salary = 0 because property Salary in class Employee is protected

            Console.ReadLine();
        }
    }
}
