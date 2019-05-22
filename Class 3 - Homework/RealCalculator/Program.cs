using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("Please enter arithmetic operation!");
                string operation = Console.ReadLine();

                string[] stringArray = new string[0] { };

                if (operation == "+" || operation == "-" || operation == "/" || operation == "*")
                {
                    
                    bool firstFlag = false;
                    bool secondFlag = false;

                    while (firstFlag == false || secondFlag == false)
                    {

                        Console.WriteLine("Enter first number!");
                        double firstNumber;
                        firstFlag = double.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("en-US"), out firstNumber);
                        
                        Console.WriteLine("Enter second number");
                        double secondNumber;
                        secondFlag = double.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("en-US"), out secondNumber);
                        
                        if(firstFlag == false || secondFlag == false)
                        {
                            Console.WriteLine("Invalid input of numbers, please try again!");
                        }
                        
                        else
                        {

                            double result;
                            if (operation == "+")
                            {
                                result = firstNumber + secondNumber;
                                Console.WriteLine("The result is: " + result);
                                
                            }
                            else if(operation == "-")
                            {
                                double minusResult;
                                if (firstNumber > secondNumber)
                                {
                                    minusResult = firstNumber - secondNumber;
                                    Console.WriteLine("The result is: " + minusResult);
                                }
                                else
                                {
                                    minusResult = secondNumber - firstNumber;
                                    Console.WriteLine("The result is: " + minusResult);
                                }
                                    

                            }
                            else if(operation == "*")
                            {
                                result = firstNumber * secondNumber;
                                Console.WriteLine("The result is: " + result);

                            }
                            else if (operation == "/" && secondNumber == 0)
                            {

                                Console.WriteLine("You can`t divide with 0, the result is infinity!");
                                continue;
                            }
                            else if(operation == "/")
                            { 
                                result = firstNumber / secondNumber;
                                Console.WriteLine("The result is: " + result);
                                
                            }
                            
                            else
                            {
                                Console.WriteLine("Invalid result");
                            }

                            Array.Resize(ref stringArray, stringArray.Length + 1);
                            stringArray[stringArray.Length - 1] = "Operation:" + operation + ";" + " " + "First Number:" + Convert.ToString(firstNumber) + ";" + " " + "secondNumber:" + Convert.ToString(secondNumber);

                            Console.WriteLine("Do you want to make another operation?");
                            string answer = Console.ReadLine();
                            
                            if(answer == "Y")
                            {    
                                continue;
                            }
                            
                            else if(answer == "N")
                            {                         
                                operation = "N";
                                Console.WriteLine("The calculation process is finished");
                                for (int i = 0; i < stringArray.Length; i++)
                                {
                                    Console.WriteLine(stringArray[stringArray.Length - 1]);
                                }
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid answer, please try again!");
                                continue;
                            }
                            
                        }
                    }                    
                }
                
                else 
                {
                    Console.WriteLine("Invalid input, please try again");
                }
                if (operation == "N")
                {
                    break;
                }

                Console.ReadLine();
            }

            
        }
    }
}
