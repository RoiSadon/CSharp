using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] arr = new Food[6];
            arr[0] = new Pizza(8, 4,100,true);
            arr[1] = new Pizza(8, 0, 100, true);
            arr[2] = new Pizza(4, 2, 100, true);
            arr[3] = new Chips(true,true, 100, true);
            arr[4] = new Chips(true, false, 100, true);
            arr[5] = new Chips(false, false, 100, true);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Price: {arr[i].Price} Is veg: {arr[i].IsVeg}");
                if(arr[i] is Pizza){
                    Console.WriteLine($"{((Pizza)arr[i]).print_info()}");
                }
                else
                {
                    Console.WriteLine($"{((Chips)arr[i]).print_info()}");
                }
            }
            



        }
    }
}
