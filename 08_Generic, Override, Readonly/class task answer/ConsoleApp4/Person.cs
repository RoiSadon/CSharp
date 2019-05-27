using System;

namespace ConsoleApp4
{
    internal class Person
    {
        public string FullName { get; set; }

        private int age;

        public int Age
        {
            get => age;
            set
            {
                if (age > 0 && age <= 120)
                { age = value; }
            }
        }

        private string id;

        public string Id
        {
            get => id;
            set
            {
                if (value.Length == 9)
                {
                    int a = Convert.ToInt32(value);
                    id = value;
                }
            }
        }

        public bool IsMale { get; set; }

        public Person(string fullName, int age, string id, bool isMale)
        {
            FullName = fullName;
            Age = age;
            Id = id;
            IsMale = isMale;
        }

        public string print_info()
        {
            return $"Person: {FullName}, Age:{Age},Id: {Id}, IsMale: {IsMale}";
        }
    }
}
