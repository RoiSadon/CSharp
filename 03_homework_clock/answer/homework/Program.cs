using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //answer 1.5.1
            Clock myClock = new Clock(12,23,54,8875);
            //answer 1.5.2
            Console.WriteLine(myClock.show());
            //answer 1.5.3
            myClock.Mili_seconds += 2;
            //answer 1.5.4
            Console.WriteLine(myClock.show());
            //answer 1.5.5
            myClock.setMidDay();
            //answer 1.5.6
            myClock.Mili_seconds += 3;
            //answer 1.5.7
            Console.WriteLine(myClock.show());

            //answer 1.5.8
            Clock yourClock = new Clock();
            //answer 1.5.9
            yourClock.setMidNight();
            //answer 1.5.10
            Console.WriteLine(yourClock.show());


        }
    }
}
