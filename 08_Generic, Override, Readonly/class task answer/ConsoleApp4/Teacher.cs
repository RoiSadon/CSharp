using System;

namespace ConsoleApp4
{
    internal class Teacher : Person
    {
        public string SubjectTeaching { get; set; }
        public int ExpYears { get; set; }

        public Teacher(string subjectTeaching, int expYears, string fullName, int age, string id, bool isMale) : base(fullName, age, id, isMale)
        {
            SubjectTeaching = subjectTeaching;
            ExpYears = expYears;
        }

        public string print_info()
        {
            return base.print_info() + $"SubjectTeaching: {SubjectTeaching},ExpYears: {ExpYears} ";
        }
    }
}
