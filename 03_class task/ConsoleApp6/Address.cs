using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Address
    {
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private int home_num;

        public int Home_num
        {
            get { return home_num; }
            set { home_num = value; }
        }

        public Address(string city,string counrty,string street,int home_num)
        {
            City = city;
            Country = counrty;
            Street = street;
            Home_num = home_num;
        }

        public string get_info()
        {
            return $"country: {Country}, city: {City}, street: {Street}, home_num:{Home_num}";
        }


    }
}
