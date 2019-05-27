using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(100);
            Console.WriteLine(Student.print_info());
            Student s2 = new Student(80);
            Console.WriteLine(Student.print_info());
            Student s3 = new Student(95);
            Console.WriteLine(Student.print_info());
            Student s4 = new Student(70);
            Console.WriteLine(Student.print_info());

            // we change s1.grade:
            s1.Grade = 92;
            Console.WriteLine(Student.print_info());

        }
    }
}
