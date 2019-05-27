using System;
namespace ConsoleApp2
{
    class Student:Person
    {
        // array of courses for student:
        Course[] arr = new Course[5];

        // StudyingYear:
        private int studyingYear;
        public int StudyingYear
        {
            get { return studyingYear; }
            set { studyingYear = value; }
        }

        // avgGrades:
        private int avgGrades;
        public int AvgGrades
        {
            get { return avgGrades; }
            set { avgGrades = value; }
        }

        // Constructor:
        public Student(int studyingYear, int avgGrades, string name, int age, int id, string address):base(name,age,id,address)
        {
            StudyingYear = studyingYear;
            AvgGrades = avgGrades;
            Course[] arr = new Course[5];
        }

    }
}
