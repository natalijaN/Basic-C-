using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise___from_Class.Classes;

namespace Exercise___from_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that will represent user Login and Register functionality.
            //On initial load program asks for an valid input("1" for Login and "2" for Register)
            //if user exists - Login is successful and print message
            //If user not exists - Register the user and try to Login
            string input = "1";
            while (input != "exit")
            {
                Console.WriteLine(@"If you want to Login - press ""1""");
                Console.WriteLine(@"If you want to Register - press ""2"" ");
                Console.WriteLine(@"If you want to Exit - write ""exit"" ");

                Users[] usersArr = new Users[]
                {
                        new Users("Natalija", "123456"),
                        new Users("Stefan", "456789"),
                        new Users("Marija", "963852"),
                        new Users("Angela", "2468"),
                        new Users("Igor", "1357"),
                };

                input = Console.ReadLine();

                while (input == "1" || input == "2")
                {

                    if (input == "1")
                    {
                        Console.WriteLine("Please enter your username!\nAttention!\nThe username must not start with number!");
                        string username = Console.ReadLine();
                        bool isDigit = false;
                        while (isDigit == false) { 
                            isDigit = !string.IsNullOrEmpty(username) && !char.IsDigit(username[0]);

                            if (isDigit == false)
                            {
                                Console.WriteLine("The username must not start with number! Please try again!");
                                username = Console.ReadLine();
                            }
                         }
                        
                        Console.WriteLine("Please enter your password!");
                        string password = Console.ReadLine();

                        bool flag = false;

                        foreach (var user in usersArr)
                        {
                            if (username.ToLower() == user.Username.ToLower() && password.ToLower() == user.Password.ToLower())
                            {
                                Console.WriteLine("Successful!");
                                flag = true;
                                break;
                            }

                        }
                        if (flag == false)
                        {
                            Console.WriteLine("You are not register! Please, try again!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter your username!");
                        string username = Console.ReadLine();

                        Console.WriteLine("Please enter your password!");
                        string password = Console.ReadLine();

                        Users newUser = new Users(username, password);

                        Array.Resize(ref usersArr, usersArr.Length + 1);
                        usersArr[usersArr.Length - 1] = newUser;

                        Console.WriteLine("You are register! Try to login!");

                    }
                    Console.WriteLine(@"If you want to Login - press ""1""");
                    Console.WriteLine(@"If you want to Register - press ""2"" ");
                    Console.WriteLine(@"If you want to Exit - write ""exit"" ");

                    input = Console.ReadLine();


                }
                Console.WriteLine("You are out of console application!");



                foreach (var user in usersArr)
                {
                    Console.WriteLine($"The user {user.Username} has an ID: {user.GetId()}");
                }

                Console.ReadLine();
            }
        }
    }
}

