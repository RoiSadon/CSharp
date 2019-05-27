using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person p1 = new Person();
            p1.Name = "Bob";
            p1.P_address = new Address("kiryat-arba", "Israel", "yeoshua", 15);
            Console.WriteLine(p1.getInfo());
        }
    }
}
