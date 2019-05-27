using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Date birthdate;

        public Date Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        private Person father;

        public Person Father
        {
            get { return father; }
            set { father = value; }
        }

        private Person mother;

        public Person Mother
        {
            get { return mother; }
            set { mother = value; }
        }

        public Person(string name, Date birthdate, Person Mother, Person Father)
        {
            Name = name;
            Birthdate = birthdate;
            Mother = mother;
            Father = father;
        }

        public string print_info()
        {
            string res = $"Name: {Name}, birthdate: {Birthdate.print_info()}";
            if (Mother != null && Father != null)
            {
                res += $"\n{Father.print_info()},\n{Mother.print_info()}";
            }
            return res;
        }



    }
}
