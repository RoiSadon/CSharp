using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Item
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private bool kosher;

        public bool Kosher
        {
            get { return kosher; }
            set { kosher = value; }
        }

        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private int expiryYear;

        public int ExpiryYear
        {
            get { return expiryYear; }
            set { expiryYear = value; }
        }

        public Item(string name, double price, bool kosher, string manufacturer, int expiryYear)
        {
            Name = name;
            Price = price;
            Kosher = kosher;
            Manufacturer = manufacturer;
            ExpiryYear = expiryYear;
        }

        public string print_info()
        {
            string res = $"Name: {Name},Price:{Price},Kosher{Kosher}, Manufacturer{Manufacturer}, ExpiryYear{ExpiryYear}  ";
            return res;
        }

        public bool expDatePass()
        {
            if (ExpiryYear <= 2018)
                return false;
            else
                return true;
        }
    }
}
