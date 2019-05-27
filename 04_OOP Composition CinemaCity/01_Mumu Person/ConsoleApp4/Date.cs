using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Date
    {
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        private int day;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public string print_info()
        {
            return $"{Day}/{Month}/{Year}";
        }

    }
}
