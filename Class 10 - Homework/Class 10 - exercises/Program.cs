using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Class_10___exercises
{   

    class Program
    {


        static void Main(string[] args)
        {
            //Academy Management Application

            //The app will have users that can login and preform some actions

            //The user can choose one of the 3 roles and login // Console.WriteLine();

            //-Admin
            //-Trainer
            //-Student (has a current Subject, and Grades)

            //After logging in there should be different options for different roles

            //Admins can add/remove Trainers, Students and other Admins (can`t remove it self)

            //Trainer can choose between seeing all students and all subjects
            // - When choosing Students, all student names should appear
            // - When chosen a name, it should print all the subjects
            // - When choosing Subjects, all Subject names appear with how many students attend it next to it

            //Student are shown subjects that they are listening and a list of their grades
            #region Initializing Lists
            Admin adminOne = new Admin("Bill", "Billsky");
            Admin adminTwo = new Admin("Jane", "Doe");
            Admin adminThree = new Admin("Stefan", "Stefanoski");
            Admin adminFour = new Admin("Jerry", "Tompson");

            List<Admin> admins = new List<Admin>() { adminOne, adminTwo, adminThree, adminFour };


            Trainer trainerOne = new Trainer("John", "Brown");
            Trainer trainerTwo = new Trainer("Stone", "Stonsky");
            Trainer trainerThree = new Trainer("Maria", "Campbel");
            Trainer trainerFour = new Trainer("Angel", "Bozinovski");

            List<Trainer> trainers = new List<Trainer>() { trainerOne, trainerTwo, trainerThree, trainerFour };

            Student studentOne = new Student("Angela", "Avramovska");
            Student studentTwo = new Student("Pavle", "Nikolov");
            Student studentThree = new Student("Stefan", "Trajkov");
            Student studentFour = new Student("Daniela", "Bozinova");

            List<Student> students = new List<Student>() { studentOne, studentTwo, studentThree, studentFour };

            Subjects subjectOne = new Subjects("HTML/CSS");
            Subjects subjectTwo = new Subjects("JavaScript");
            Subjects subjectThree = new Subjects("AdvancedJavaScript");
            Subjects subjectFour = new Subjects("Basic C#");

            List<Subjects> subjects = new List<Subjects> { subjectOne,subjectTwo, subjectThree, subjectFour};


            studentOne.MySubject = new Dictionary<Subjects,int>();

            studentOne.MySubject.Add(subjectOne,5);
            studentOne.MySubject.Add(subjectThree,3);

            studentTwo.MySubject = new Dictionary<Subjects,int>();

            studentTwo.MySubject.Add(subjectOne,4);
            studentTwo.MySubject.Add(subjectTwo,5);
            studentTwo.MySubject.Add(subjectFour,4);


            studentThree.MySubject = new Dictionary<Subjects, int>();

            studentThree.MySubject.Add(subjectOne,5);
            studentThree.MySubject.Add(subjectFour,5);
            studentThree.MySubject.Add(subjectThree,5);

            studentFour.MySubject = new Dictionary<Subjects, int>();

            studentFour.MySubject.Add(subjectTwo,3);
            studentFour.MySubject.Add(subjectOne,5);

            var nameOfSubjectOne = subjectOne.NameOfSubject;
            int index = 0;

            foreach (var student in students)
            {
                var listofsubjects = student.MySubject.Where(s => s.Key.NameOfSubject == nameOfSubjectOne).ToList();
                if(listofsubjects.Count != 0)
                {
                    index++;
                }
                
            }

            subjectOne.indicatiorOfStudents = index;

            var nameOfSubjectTwo = subjectTwo.NameOfSubject;
            int index2 = 0;

            foreach (var student in students)
            {
                var listofsubjects = student.MySubject.Where(s => s.Key.NameOfSubject == nameOfSubjectTwo).ToList();
                if (listofsubjects.Count != 0)
                {
                    index2++;
                }

            }

            subjectTwo.indicatiorOfStudents = index2;

            var nameOfSubjectThree = subjectThree.NameOfSubject;
            int index3 = 0;

            foreach (var student in students)
            {
                var listofsubjects = student.MySubject.Where(s => s.Key.NameOfSubject == nameOfSubjectThree).ToList();
                if (listofsubjects.Count != 0)
                {
                    index3++;
                }

            }

            subjectThree.indicatiorOfStudents = index3;

            var nameOfSubjectFour = subjectThree.NameOfSubject;
            int index4 = 0;

            foreach (var student in students)
            {
                var listofsubjects = student.MySubject.Where(s => s.Key.NameOfSubject == nameOfSubjectFour).ToList();
                if (listofsubjects.Count != 0)
                {
                    index4++;
                }

            }

            subjectFour.indicatiorOfStudents = index4;

#endregion

            Console.WriteLine("Login on Academy Managemnt Application!");
            Console.WriteLine();
           
            Console.WriteLine("Press 1) for Admin");
            Console.WriteLine("Press 2) for Trainer");
            Console.WriteLine("Press 3) for Student");
            Console.WriteLine();

            try
            {
                int roleInput = Convert.ToInt32(Console.ReadLine());
        
                switch (roleInput)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Please enter your first name!");
                        string firstName = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please enter your last name!");
                        string lastName = Console.ReadLine();
                        Console.WriteLine();

                        var currentAdmin = admins.Where(a => a.FirstName.ToLower().Trim() == firstName.ToLower().Trim() && a.LastName.ToLower().Trim() == lastName.ToLower().Trim()).ToList();

                        if (currentAdmin.Count == 0)
                        {
                            Console.WriteLine("There is no admin with that personal infos!");
                        }
                        else
                        {
                            //Admin 

                            Console.WriteLine("If you want to add Admins/Trainers/Students press 1");
                            Console.WriteLine("If you want to remove Admins/Trainers/Students press 2");
                            Console.WriteLine();

                            try
                            {
                                
                                int inputChoice = Convert.ToInt32(Console.ReadLine());
                                if (inputChoice == 1)
                                {
                                    // Add in list
                                    Admin.Add(admins, trainers, students);    
                                }

                                else if(inputChoice == 2)
                                {
                                    //Remove from list, but not it`s self
                                    
                                    Admin.Remove(admins, trainers, students, firstName, lastName);
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input!");
                                }

                            }
                            catch (Exception ex)
                            { 
                                Console.WriteLine(ex.Message);
                                
                            }
                            
                            //RemoveAdmins();
                        }

                        break;
                    case 2:
                        //Trainer
                        Console.Clear();
                        Console.WriteLine("Please enter your first name!");
                        string firstNameTrainer = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please enter your last name!");
                        string lastNameTrainer = Console.ReadLine();
                        Console.WriteLine();

                        var currentTrainer = trainers.Where(a => a.FirstName.ToLower().Trim() == firstNameTrainer.ToLower().Trim() && a.LastName.ToLower().Trim() == lastNameTrainer.ToLower().Trim()).ToList();

                        if (currentTrainer.Count == 0)
                        {
                            Console.WriteLine("There is no trainer with that personal infos!");
                        }
                        else
                        {
                            //Trainer

                            Console.WriteLine("If you want to see all Students -> press 1");
                            Console.WriteLine("If you want to see all Subjects -> press 2");
                            Console.WriteLine();

                            try
                            {
                                int inputChoice = Convert.ToInt32(Console.ReadLine());
                                if (inputChoice == 1)
                                {
                                    //See all Students
                                    foreach (var student in students)
                                    {
                                        student.GetFullName();
                                   
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Write the first name of the student you want to search!");
                                    Console.WriteLine();

                                    string studentName = Console.ReadLine();

                                    var studentInStudents = students.Where(s => s.FirstName.ToLower().Trim() == studentName.ToLower().Trim()).FirstOrDefault();

                                    if (studentInStudents == null)
                                    {
                                        Console.WriteLine("Wrong input of name!");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{studentInStudents.FirstName} has attend to: ");
                                        Console.WriteLine();
                                        int number = 1;
                                        foreach (var subject in studentInStudents.MySubject)
                                        {
                                            Console.WriteLine($"{number}){subject.Key.NameOfSubject}");
                                            number++;
                                        }
                                    }

                                }

                                else if (inputChoice == 2)
                                {
                                    //See all Subjects
                                    Console.WriteLine("All subjects:");

                                    //When choosing Subjects, all Subject names appear with how many students attend it next to it


                                    foreach (var subject in subjects)
                                    {
                                        
                                        Console.WriteLine($"{subject.NameOfSubject} -> {subject.indicatiorOfStudents} students attend to it!" );
                                    }
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input!");
                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);

                            }
                            
                        }
                        break;
                    case 3:
                        //Student are shown subjects that they are listening and a list of their grades

                        Console.WriteLine("Please enter your first name!");
                        string firstNameStudent = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please enter your last name!");
                        string lastNameStudent = Console.ReadLine();
                        Console.WriteLine();

                        var currentStudent = students.Where(a => a.FirstName.ToLower() == firstNameStudent.ToLower() && a.LastName.ToLower() == lastNameStudent.ToLower()).ToList();
                        Console.WriteLine();

                        if (currentStudent.Count == 0)
                        {
                            Console.WriteLine("There is no student with that personal infos!");
                        }
                        else
                        {
                            foreach (var student in currentStudent)
                            {
                                student.GetFullName();

                                foreach (var subject in student.MySubject)
                                {
                                    Console.WriteLine($"Subject: {subject.Key.NameOfSubject} -> Grade: {subject.Value}");
                                }
                                Console.WriteLine();
                            }
                            
                        }
                            break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
        
    }
}
