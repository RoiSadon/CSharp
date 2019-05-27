using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Gogo", new Date(1942, 4, 17), null, null);
            Person p2 = new Person("Gigi", new Date(1945, 8, 21), null, null);
            Person p3 = new Person("Mumu", new Date(1980, 5, 8),p2,p1);
            
            Console.WriteLine(p3.print_info());
            Console.WriteLine(p1.print_info());
        }
    }
}
