using System;
namespace ConsoleApp2
{
    class Lecturer:Person
    {
        // array of teaching courses:
        Course[] arrWhatYouTeach = new Course[5];

        // teachingYear:
        private int teachingYear;
        public int TeachingYear
        {
            get { return teachingYear; }
            set { teachingYear = value; }
        }

        // avgGrades:
        private int avgGrades;
        public int AvgGrades
        {
            get { return avgGrades; }
            set { avgGrades = value; }
        }

        // id:
        private int idTearcher;
        public int IdTearcher
        {
            get { return idTearcher; }
            set { idTearcher = value; }
        }

        // salary:
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Constructor:
        public Lecturer(int teachingYear, int idTearcher, int salary, string name, int age, int id, string address) : base(name, age, id, address)
        {
            TeachingYear = teachingYear;
            IdTearcher = idTearcher;
            Salary = salary;
            Course[] arrWhatYouTeach = new Course[5];
        }

    }
}
