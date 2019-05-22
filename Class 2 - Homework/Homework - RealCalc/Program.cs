using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___RealCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /* “RealCalculator” console application */

            Console.WriteLine("Please enter type of arithetic operation!");
            string operation = Console.ReadLine();
            if(operation == "+" || operation == "-" || operation == "/" || operation == "*")
            {
                Console.WriteLine("Enter first number");
                double firstNumber;
                bool firstFlag = double.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("en-US"), out firstNumber);
                
                Console.WriteLine("Enter second number");
                double secondNumber;
                bool secondFlag = double.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("en-US"), out secondNumber);

                if(firstFlag == false || secondFlag == false)
                {
                    Console.WriteLine("Invalid input numbers, please try again.");
                }
                else
                {
                   switch (operation)
                    {
                        case "+":
                            double result = firstNumber + secondNumber;
                            Console.WriteLine("The result is: " + result);
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            Console.WriteLine("The result is: " + result);
                            break;
                        case "/":
                            result = firstNumber / secondNumber;
                            Console.WriteLine("The result is: " + result);
                            break;
                        case "*":
                            result = firstNumber * secondNumber;
                            Console.WriteLine("The result is: " + result);
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }

                }
                
            }
            else
            {
                Console.WriteLine("Invalid operation selected, please try again.");
            }
            Console.ReadLine();
        }
    }
}
