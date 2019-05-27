using System;

namespace Homework_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 2 instances:
            Square s1 = new Square(5, 4, "red", 10.2);
            Circle c1 = new Circle(1, 6, "blue", 4.32);

            // Print their info: 
            Console.WriteLine(s1.print_info());
            Console.WriteLine(c1.print_info());
        }
    }
}
