using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Clock
    {
        private int hours;
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        private int minutes;
        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        private int seconds;
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        //answer 1.1:
        private int mili_seconds;
        public int Mili_seconds
        {
            get { return mili_seconds; }
            set { mili_seconds = value; }
        }

        public void tick()
        {
            mili_seconds = mili_seconds + 1000;
            seconds = seconds + 1;
            minutes = minutes + seconds / 60;
            hours = hours + minutes / 60;
            mili_seconds = mili_seconds % 60;
            seconds = seconds % 60;
            minutes = minutes % 60;
            hours = hours % 24;
        }

        //answer 1.2:
        public string show()
        {
            return $"The current time is: {Hours}:{Minutes}:{Seconds}:{Mili_seconds}";
        }

        //answer 1.3:
        public void setMidNight(){
            mili_seconds = 0;
            seconds = 0;
            minutes = 0;
            hours=24;
        }

        public void setMidDay()
        {
            mili_seconds = 0;
            seconds = 0;
            minutes = 0;
            hours = 12;
        }

        public Clock(int mili_seconds,int seconds,int minutes,int hours)
        {
            Mili_seconds = mili_seconds;
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
        }

        public Clock()
        {

        }

    }
}
