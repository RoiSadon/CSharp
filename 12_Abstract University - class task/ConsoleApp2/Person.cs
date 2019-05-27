using System;
namespace ConsoleApp2
{
    abstract class Person
    {
        // Attributes: 

        // name:
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // age:
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // id:
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // address:
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        // Constructor:
        public Person(string name, int age, int id, string address)
        {
            Name = name;
            Age = age;
            Id = id;
            Address = address;
        }
    }
}
