using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Chips: Food
    {
        private bool isExtraBig;
        public bool IsExtraBig
        {
            get { return isExtraBig; }
            set { isExtraBig = value; }
        }

        private bool isWithPipes;
        public bool IsWithPipes
        {
            get { return isWithPipes; }
            set { isWithPipes = value; }
        }

        public Chips(bool isExtraBig, bool isWithPipes,int price,bool isVeg):base(price,isVeg)
        {
            IsExtraBig = isExtraBig;
            IsWithPipes = isWithPipes;
        }

        public string print_info()
        {
            return $"IsExtraBig: {IsExtraBig}, IsWithPipes: {IsWithPipes}";
        }

    }
}
