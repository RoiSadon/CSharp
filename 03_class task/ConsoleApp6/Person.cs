using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Address p_address;

        public Address P_address
        {
            get { return p_address; }
            set { p_address = value; }
        }

        public Person(string name,Address p_address)
        {
            Name = name;
            P_address = p_address;
        }

        public Person()
        {

        }

        public string getInfo()
        {
            string res = $"city: {P_address.City}, country: {P_address.Country}, street:{P_address.Street}, number: {P_address.Home_num}";
            return $"name:{Name}, address:{res}";
        }




    }
}
