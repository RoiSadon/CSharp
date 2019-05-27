using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Shop
    {
        public ElectronicItems[] supply = new ElectronicItems[6];

        // Methods:

        // Suggest sell:
        public void SuggestSell(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("You want to buy computer:");
                    for(int i = 0; i < supply.Length; i++)
                    {
                        if (supply[i] is Computer)
                        { Console.WriteLine($"{i}. {supply[i].print_info()}"); }
                    }
                    break;
                case 2:
                    Console.WriteLine("You want to buy phone:");
                    for (int i = 0; i < supply.Length; i++)
                    {
                        if (supply[i] is Pelephone)
                        { Console.WriteLine($"{i}. {supply[i].print_info()}"); }
                    }
                    break;

            }
        }

        // Sell:
        public string Sell(int index)
        {
            return $"You bought: \nIndex: {index},{supply[index].print_info()}, Warranty years: {supply[index].WarrantyYears}";
        }
    }
}
