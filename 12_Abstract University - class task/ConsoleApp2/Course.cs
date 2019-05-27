using System;
namespace ConsoleApp2
{
    class Course
    {
        // Attributes: 

        // name:
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // number:
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        // grade:
        private int grade;
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        // Constructor:
        public Course(string name, int number, int grade)
        {
            Name = name;
            Number = number;
            Grade = grade;
        }
    }
}
