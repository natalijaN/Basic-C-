using Classes_and_objects.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{


    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human();

            person.FirstName = "Miodrag";

            person.LastName = Console.ReadLine();


            Product product = new Product();

            product.name = "Mobilen";
            product.price = 100;

            string cena = Convert.ToString(product.PriceWithDiscount());

            Console.WriteLine("Ke go kupis mobilniot za: " + cena);

            Console.ReadLine();

        }
    }
}
