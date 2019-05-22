using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Admin : Person
    {
       

        public Admin(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
           
        }

        public static void Remove(List<Admin> admins, List<Trainer> trainers, List<Student> students, string userFirstName, string userLastName)
        {
            Console.Clear();
            Console.WriteLine("If you want to remove Admin press 1");
            Console.WriteLine("If you want to remove Trainer press 2");
            Console.WriteLine("If you want to remove Student press 3");
            Console.WriteLine();

            try
            {
                int removeChoice = Convert.ToInt32(Console.ReadLine());

                switch (removeChoice)
                {
                    case 1:
                        //Remove admin from list of admins

                        foreach (var admin in admins)
                        {
                            admin.GetFullName();
                        }

                        Console.WriteLine("Enter first name of admin!");
                        string adminName = Console.ReadLine();
                        adminName = Helpers.FirstCharToUpper(adminName);
                        Console.WriteLine();

                        Console.WriteLine("Enter last name of admin!");
                        string adminLastName = Console.ReadLine();
                        adminLastName = Helpers.FirstCharToUpper(adminLastName);
                        Console.WriteLine();

                        if (userFirstName.ToLower() == adminName.ToLower() && userLastName.ToLower() == adminLastName.ToLower())
                        {
                            Console.WriteLine("Sorry you can not remove your self!");
                            return;
                        }
                        else
                        {
                            var adminForRemove = admins.RemoveAll(a => a.FirstName == adminName && a.LastName == adminLastName);
                        }

                        foreach (var admin in admins)
                        {
                            admin.GetFullName();
                        }

                        break;
                    case 2:
                        //Remove trainer from list of trainers

                        foreach (var trainer in trainers)
                        {
                            trainer.GetFullName();
                        }

                        Console.WriteLine("Enter first name of trainer!");
                        string trainerName = Console.ReadLine();
                        trainerName = Helpers.FirstCharToUpper(trainerName);
                        Console.WriteLine();

                        Console.WriteLine("Enter last name of trainer!");
                        string trainerLastName = Console.ReadLine();
                        trainerLastName = Helpers.FirstCharToUpper(trainerLastName);
                        Console.WriteLine();


                        var trainerForRemove = trainers.RemoveAll(t => t.FirstName.Trim() == trainerName.Trim() && t.LastName.Trim() == trainerLastName.Trim());

                        if (trainerForRemove == 0)
                        {
                            Console.WriteLine("There is no such trainer in this academy!");
                        }

                        Console.WriteLine();
                        Console.WriteLine("List of trainers:");
                        Console.WriteLine();

                        foreach (var trainer in trainers)
                        {
                            trainer.GetFullName();
                        }

                        break;
                    case 3:
                        foreach (var student in students)
                        {
                            student.GetFullName();
                        }

                        Console.WriteLine("Enter first name of student!");
                        string studentName = Console.ReadLine();
                        studentName = Helpers.FirstCharToUpper(studentName);
                        Console.WriteLine();

                        Console.WriteLine("Enter last name of student!");
                        string studentLastName = Console.ReadLine();
                        studentLastName = Helpers.FirstCharToUpper(studentLastName);
                        Console.WriteLine();

                        var studentForRemove = students.RemoveAll(s => s.FirstName.Trim() == studentName.Trim() && s.LastName.Trim() == studentLastName.Trim());

                        if (studentForRemove == 0)
                        {
                            Console.WriteLine("There is no such student in this academy!");
                        }

                        Console.WriteLine();
                        Console.WriteLine("List of students:");
                        Console.WriteLine();

                        foreach (var student in students)
                        {
                            student.GetFullName();
                        }

                        break;
                    default:
                        Console.WriteLine("You entered wrong number!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static void Add(List<Admin> admins, List<Trainer> trainers, List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("If you want to add Admin press 1");
            Console.WriteLine("If you want to add Trainer press 2");
            Console.WriteLine("If you want to add Student press 3");
            Console.WriteLine();

            try
            {
                int choiceAdd = Convert.ToInt32(Console.ReadLine());
                switch (choiceAdd)
                {
                    case 1:
                        //Adding admin to list of admins

                        Console.WriteLine("Enter first name of admin!");
                        string adminName = Console.ReadLine();
                        adminName = Helpers.FirstCharToUpper(adminName);
                        Console.WriteLine();

                        Console.WriteLine("Enter last name of admin!");
                        string adminLastName = Console.ReadLine();
                        adminLastName = Helpers.FirstCharToUpper(adminLastName);
                        Console.WriteLine();

                        Admin newAdmin = new Admin(adminName, adminLastName);

                        admins.Add(newAdmin);

                        Console.WriteLine("List of admins: ");
                        foreach (var admin in admins)
                        {
                            admin.GetFullName();
                        }

                        break;
                    case 2:
                        //Add trainer to list of trainers
                        Console.WriteLine("Enter first name of trainer!");
                        string trainerName = Console.ReadLine();
                        trainerName = Helpers.FirstCharToUpper(trainerName);

                        Console.WriteLine("Enter last name of trainer!");
                        string trainerLastName = Console.ReadLine();
                        trainerLastName = Helpers.FirstCharToUpper(trainerLastName);
                        Console.WriteLine();

                        Trainer newTrainer = new Trainer(trainerName, trainerLastName);

                        Console.WriteLine("List of trainers: ");
                        foreach (var trainer in trainers)
                        {
                            trainer.GetFullName();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter first name of student!");
                        string studentName = Console.ReadLine();
                        studentName = Helpers.FirstCharToUpper(studentName);
                        Console.WriteLine();

                        Console.WriteLine("Enter last name of student!");
                        string studentLastName = Console.ReadLine();
                        studentLastName = Helpers.FirstCharToUpper(studentLastName);
                        Console.WriteLine();

                        Student newStudent = new Student(studentName, studentLastName);

                        students.Add(newStudent);

                        Console.WriteLine("List of students: ");
                        foreach (var student in students)
                        {
                            student.GetFullName();
                        }

                        break;
                    default:
                        Console.WriteLine("You entered wrong number!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }

        }
    }
