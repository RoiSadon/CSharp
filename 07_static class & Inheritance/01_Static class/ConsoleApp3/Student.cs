using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student
    {
        // define private and public grade attriblute:
        private int grade;
        public int Grade
        {
            get { return grade; }
            set
            {
                // if in set: if value is between 0-100
                if (value >= 0 && value <= 100)
                {
                    // we sub grades from sumGrades. 
                    // reason: in case we change the grade to person. (it will be discounted first).
                    // else will be 0 as default.
                    sumGrades -= grade;
                    grade = value;
                    sumGrades += grade;
                }
            }
        }

        // we use static usually for sum,avg,counter,
        // it will be the same one for the entire class. 

        // define static sumGrades- will be used one for all the class. 
        public static int sumGrades = 0;
        // define static counter- will be used one for all the class. 
        public static int counter = 0;

        // ctor- constructor for the class. 
        // counter will be ++ each time new Student is created. 
        public Student(int grade)
        {
            Grade = grade;
            counter++;
        }

        // Function to return string of info about class's attributes. 
        // will be static!! reason: we print only static attributes.
        public static string print_info()
        {
            return $"The avg of {counter} Students is:{sumGrades / counter}";
        }



    }
}