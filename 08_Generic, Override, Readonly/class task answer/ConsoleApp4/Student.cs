using System;

namespace ConsoleApp4
{
    internal class Student: Person
    {
        public string University { get; set; }
        public string Subject { get; set; }

        public Student(string university, string subject, string fullName, int age, string id, bool isMale) : base(fullName, age, id, isMale)
        {
            University = university;
            Subject = subject;
        }

        public string print_info()
        {
            return base.print_info() + $"University: {University},Subject: {Subject} ";
        }
    }
}
