using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] arr = new Item[5];
            arr[0] = new Item("Cofee", 5.5, true, "1", 2018);
            arr[1] = new Item("Shoko", 7.5, true, "1", 2018);
            arr[2] = new Item("Bamba", 10, true, "1", 2020);
            arr[3] = new Item("Choclate", 12, true, "1", 2019);
            arr[4] = new Item("Bisly", 5.3, true, "1", 2016);

            for (int i = 0; i < arr.Length; i++)
            {         
                Console.WriteLine(arr[i].print_info());
                Console.WriteLine("Is expire day passed? "+arr[i].expDatePass());
                Console.WriteLine("");
            }
        }
    }
}
