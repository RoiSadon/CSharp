using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Movie
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Movie(string name, int length)
        {
            Name = name;
            Length= length;
        }

        public string print_info()
        {
            return $"Movie: {Name}, length: {Length} ";
        }
    }
}
