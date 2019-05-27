using System;

namespace ConsoleApp4
{
    internal class Cinema
    {
        public string Name { get; set; }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 30 && value <= 200)
                {
                    price = value;
                }
            }
        }

        public readonly int T_discount = 0;
        public readonly int S_discount = 0;

        public Cinema(string name, int price)
        {
            Random r = new Random();
            Name = name;
            Price = price;
            T_discount = r.Next(5, 10);
            S_discount = r.Next(10, 20);
        }

        public string print_info()
        {
            return $"Name: {Name}, Price:{Price},T_discount: {T_discount}, S_discount: {S_discount}";
        }
    }
}
