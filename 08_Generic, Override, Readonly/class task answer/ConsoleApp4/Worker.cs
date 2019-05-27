using System;

namespace ConsoleApp4
{
    internal class Worker: Person
    {
        public int Salary { get; set; }
    
        public Worker(int salary,string fullName, int age, string id, bool isMale) : base(fullName, age, id, isMale)
        {
            Salary = salary;
        }

        public string print_info()
        {
            return base.print_info() + $"Salary: {Salary}";
        }
    }
}
