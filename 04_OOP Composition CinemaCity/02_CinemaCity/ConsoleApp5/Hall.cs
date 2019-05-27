using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Hall
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private Movie movieNow;

        public Movie MovieNow
        {
            get { return movieNow; }
            set { movieNow = value; }
        }

        private bool[][] chairs;

        public bool[][] Chairs
        {
            get { return chairs; }
            set { chairs = value; }
        }

        public Hall(Movie movieNow)
        {
            Chairs = new bool[10][];
            for(int i = 0; i < Chairs.Length; i++)
            {
                Chairs[i] = new bool[8];
            }
            MovieNow = movieNow;
        }

       public bool buyChair(int amount)
        {
            for (int row = 0; row < Chairs.Length; row++)
            {
                for (int col = 0; col < Chairs.Length; col++)
                {
                    if(!Chairs[row][col])
                    {
                        amount--;
                        Chairs[row][col] = true;
                    }
                    if (amount == 0)
                        break;
                }
                if (amount == 0)
                    break;
            }
            return amount == 0;
        }

        public string print_info()
        {
            string res = $"Movie in {Number} hall: {MovieNow.print_info()}";
            res += "\n\nThe Chairs in this room : (V=ordered. X = not ordered)\n";

            foreach (bool[] arr in Chairs)
            {
                foreach (bool e in arr)
                {
                    res += (e) ? "V | " : " X | ";
                }
                res += "\n--------------------------------------------\n";
            }
            return res;
        }





    }
}
