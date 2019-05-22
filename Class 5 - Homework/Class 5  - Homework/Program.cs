using System;
using Class_5____Homework.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_5____Homework
{
    class Program
    {
        
        static void Buyer(Product[] products,string buyerInput, Cart cartOfBuyer, Person buyer)
        {
            int couter = 0;
            while(buyerInput != "exit")
            {
                bool found = false;
                for (var i = 0; i < products.Length; i++)
                {  
                    if (buyerInput.ToLower() == products[i].Name.ToLower())
                    {
                        found = true;                       
                        Array.Resize(ref cartOfBuyer.ListOfProducts, cartOfBuyer.ListOfProducts.Length + 1);
                        //cartOfBuyer.ListOfProducts[couter] = products[i].Name + ";" +  products[i].SerialNumber + ";" + products[i].Declaration + ";" + products[i].Description + "\n";
                        cartOfBuyer.ListOfProducts[couter] = products[i].Name;
                        Console.WriteLine("OK!Please select another product!");
                        couter++;
                        buyerInput = Console.ReadLine();
                        break;  
                    }  
                }

                if (found == false)
                {
                    Console.WriteLine("There is no such product!Please select another product!");
                    buyerInput = Console.ReadLine();
                }

            }

            Cashier(cartOfBuyer, buyer,products);
        }

        static void Cashier(Cart cartOfBuyer, Person buyer, Product[] products)
        {
            Console.WriteLine("Cashier: Hello!");
            Console.WriteLine($"{FirstCharToUpper(buyer.FirstName)}: Hello!");

            int ageOfBuyer = AgeCalculator(buyer.DateOfBirth);
            double totalPrice = 0;

            foreach (var product in cartOfBuyer.ListOfProducts)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if(product == products[i].Name)
                    {
                        
                        if(products[i].Declaration == "Only for adults" && ageOfBuyer < 18)
                        {
                            Console.WriteLine($"Sorry, you can not buy this product {products[i].Name}");
                            
                        }
                        else
                        {
                            totalPrice += Convert.ToInt32(products[i].Description);

                        }
                    }
                }
            }
            var billForPay = PayTheBill(totalPrice, buyer);
            Console.WriteLine("You need to pay {0:C} in total", billForPay);
            Console.ReadLine();
            Console.WriteLine("Thank you, have a nice day!");
            Console.ReadLine();
            Console.WriteLine("Bye, you too!");
            
        }
        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        static double PayTheBill(double totalPrice, Person buyer)
        {
            if(totalPrice > 50 && buyer.BuyerCart == true)
            {
                totalPrice = totalPrice - totalPrice * 0.25;
                return totalPrice;
            }
            else if (totalPrice > 50)
            {
                totalPrice = totalPrice - totalPrice * 0.1;
                return totalPrice;
            }
            else
            {
                return totalPrice;
            }
  
        }


        static int AgeCalculator(DateTime birthdate)
        {
            DateTime currentTime = DateTime.Now;
            int age = currentTime.Year - birthdate.Year;
            if (birthdate.Month > currentTime.Month) age--;
            if (birthdate.Month == currentTime.Month && birthdate.Day > currentTime.Day) age--;
            return age;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"Welcome!Press ""1"" to start buying!");
            int personalInfo;
            
            while(!Int32.TryParse(Console.ReadLine(), out personalInfo) || personalInfo != 1)
            {
                Console.WriteLine("Invalid input! Тry again!");
                Console.WriteLine(@"Press ""1"" to start buying!");
            }

            Product[] products = new Product[]
            {
                new Product("Milk", 12345, "5","For all users"),
                new Product("Vodka",678910, "50","Only for adults"),
                new Product("Coca Cola",111213, "7","For all users"),
                new Product("Winston",141516, "12","Only for adults"),
                new Product("Milka",171819, "8","For all users")
            };

            if(personalInfo == 1)
            {
                Person buyer = new Person();
                Console.WriteLine("Please enter you first name!");
                buyer.FirstName = Console.ReadLine();

                Console.WriteLine("Please enter you last name!");
                buyer.LastName = Console.ReadLine();

                Console.WriteLine("Enter your birthdate in format: month-day-year");
                buyer.DateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Please enter you security number!");
                buyer.SecurityNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter if you have buyerCard!");
                buyer.BuyerCart = Convert.ToBoolean( Console.ReadLine());

                Console.WriteLine("Please select a product:");
                
                for (var i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name}");
                }
                Console.WriteLine(@"Write ""exit"" if the selection is finished!");

                Cart cartOfBuyer = new Cart(); 

                string buyerInput = Console.ReadLine();
                Buyer(products, buyerInput, cartOfBuyer, buyer);
            }
 
            Console.ReadLine();
        }
    }
}
