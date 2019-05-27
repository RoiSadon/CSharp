using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Food
    {
        public Food(decimal price, bool isVeg)
        {
            Price = price;
            IsVeg = isVeg;
        }

        public Food(decimal price, object isVeg)
        {
            this.price = price;
            this.isVeg = isVeg;
        }

        //propfull
        private decimal price;
        private object isVeg;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        //prop
        public bool IsVeg { get; set; }

    }
}
