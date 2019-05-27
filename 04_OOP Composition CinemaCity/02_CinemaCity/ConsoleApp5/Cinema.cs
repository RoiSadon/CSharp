using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Cinema
    {
        private Movie[] movieArr;

        public Movie[] MovieArr
        {
            get { return movieArr; }
            set { movieArr = value; }
        }

        private Hall[] roomsArr;

        public Hall[] RoomsArr
        {
            get { return roomsArr; }
            set { roomsArr = value; }
        }

        public Cinema()
        {
            MovieArr = new Movie[100];
            RoomsArr = new Hall[6];
        }

        public bool buyTicket(string movieName, int amount)
        {
            bool res = false;
            for (int i = 0; i < RoomsArr.Length; i++)
            {
                if(RoomsArr[i] != null && RoomsArr[i].MovieNow.Name == movieName)
                {
                    res = RoomsArr[i].buyChair(amount);
                }
            }
            return res;
        }

        public string print_info()
        {
            string res = "";
            for (int i = 0; i < RoomsArr.Length; i++)
            {
                if(RoomsArr[i] != null)
                {
                    res += $"\n------------------ROOM {i}--------------------------\n\n";
                    res += RoomsArr[i].print_info();
                }
            }
            return res;
        }

    }
}





















