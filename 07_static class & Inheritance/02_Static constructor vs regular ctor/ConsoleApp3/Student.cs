using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student
    {
        // Normal Constructor:
        // constructor- running each time an instance is created. 
        public Student(string name)
        {
            Console.WriteLine($"{name} is created!");
        }

        // Static constructor:
        // Running only the first time the class is in use. 
        // Access modofiers are not allowed on static constructors. 
        // A static constructor must be parameterless.
        static Student()
        {
            Console.WriteLine("I am static constructor!");
        }

    }
}
