using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Pizza: Food
    {
        private int numOfSlices;

        public int NumOfSlices
        {
            get { return numOfSlices; }
            set { numOfSlices = value; }
        }

        private int numOfToppings;

        public int NumOfToppings
        {
            get { return numOfToppings; }
            set { numOfToppings = value; }
        }

        public Pizza(int numOfSlices,int numOfToppings, int price, bool isVeg) : base(price, isVeg)
        {
            NumOfSlices = numOfSlices;
            NumOfToppings = numOfToppings;
        }

        public string print_info()
        {
            return $"NumOfSlices: {NumOfSlices}, NumOfToppings: {NumOfToppings}";
        }
    }
}
