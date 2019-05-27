using System;
using System.Collections.Generic;
using System.Text;

namespace _02_homework_Car
{
    class Car
    {
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string print_info()
        {
            return $"Car has: Speed of:{speed} km";
        }




    }
}
