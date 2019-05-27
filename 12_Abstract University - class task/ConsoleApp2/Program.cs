using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array of 5 people:
            Person[] arrayPeople = new Person[5];

            // Init array:
            arrayPeople[0] = new Student(2,95,"Tom",31,2,"Eilat");
            arrayPeople[1] = new Student(1, 95, "Bob", 20, 1, "Ariel");
            arrayPeople[2] = new Lecturer(10,1,30000, "Teacher1", 50, 1, "Ariel");
            arrayPeople[3] = new Lecturer(5,2,40000, "Teacher2", 45, 2, "Jerusalem");
            arrayPeople[4] = new Student(4, 95, "Alice", 22, 4, "Jerusalem");

            // Print name + Student.avg grades, or Lecturer.Salary
            foreach (Person item in arrayPeople)
            {
                if(item is Student) {
                    var x = (Student)item;
                    Console.WriteLine($"Name: {x.Name},\t Grades: {x.AvgGrades}");
                }
                if (item is Lecturer)
                {
                    var x = (Lecturer)item;
                    Console.WriteLine($"Name: {x.Name},\t Salary: {x.Salary}");
                }

            }

        }
    }
}
