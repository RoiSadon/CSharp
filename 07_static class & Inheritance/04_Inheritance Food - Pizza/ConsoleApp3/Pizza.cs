using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    // Define inheritance: sun: father
    class Pizza: Food
    {
        private int nomOfSlices;

        public int NomOfSlices
        {
            get { return nomOfSlices; }
            set { nomOfSlices = value; }
        }


        // Constructor of pizza. gets 1 attribute from pizza 
        // gets 2 attributes from Food class. (using :base()). 
        public Pizza(decimal price, bool isVeg, int nomOfSlices) : base(price,isVeg)
        {
            NomOfSlices = nomOfSlices;
        }
    }
}
