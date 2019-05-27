using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie("Avatar", 150);
            Movie m2 = new Movie("Alice in wonderland", 120);

            Hall h1 = new Hall(m1);
            Hall h2 = new Hall(m2);

            Cinema CinemaCity = new Cinema();

            CinemaCity.RoomsArr[0] = h1;
            CinemaCity.RoomsArr[1] = h2;

            CinemaCity.buyTicket("Avatar", 4);
            CinemaCity.buyTicket("Alice in wonderland", 6);

            Console.WriteLine(CinemaCity.print_info());
        }
    }
}
