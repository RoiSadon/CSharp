using System;

namespace ConsoleApp3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p = new Pizza(100,true,8);
            Console.WriteLine($"the pizza has {p.NomOfSlices} slices, and costs {p.Price}");
            Console.WriteLine("pizza is" + (p.IsVeg? " veg" : "non-veg"));
        }
    }
}
