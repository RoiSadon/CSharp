using System;

namespace _02_homework_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            //answer 2.1
            Car myCar = new Car();
            myCar.Speed = 5;

            //answer 2.2
            Console.WriteLine("");
            Console.WriteLine("     Car myCar info:");
            Console.WriteLine("--------------------------");
            Console.WriteLine(myCar.print_info());

            //answer 2.3         
            Console.WriteLine("How much speed-up would you like to add?");
            int user_speed = Convert.ToInt32(Console.ReadLine());
            myCar.Speed += user_speed;

            //answer 2.4:
            Console.WriteLine(myCar.print_info());

            //answer 2.5:
            myCar.Speed -= 2;

            //answer 2.6
            Console.WriteLine("     Speed Lower -2 km");
            Console.WriteLine(myCar.print_info());

            //answer 2.7:
            Console.WriteLine("     Stop the car:");
            myCar.Speed = 0;
            Console.WriteLine(myCar.print_info());


        }
    }
}
