using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects.Classes
{
    class Product
    {
        public string name;
        public int price;
        private int discount = 10;

        public int PriceWithDiscount()
        {
            return price - discount;
        }
    }
}
