using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    // Inheritance - father class:
    class Food
    {
        // Propfull:
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        // Prop:
        public bool IsVeg { get; set; }

        // Constructor:
        public Food(decimal price, bool isVeg)
        {
            Price = price;
            IsVeg = isVeg;
        }

    }
}
