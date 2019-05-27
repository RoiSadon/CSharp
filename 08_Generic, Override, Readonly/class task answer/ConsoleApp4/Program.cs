using System;

namespace ConsoleApp4
{
    class Program
    {

        public static void func(Person[] arr,Cinema c)
        {
            // calculate sum:
            int sum = 0,pay=0,s=0,t=0,w=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Student)
                {
                    pay = Convert.ToInt32(c.Price + (c.Price * c.S_discount));
                    s++;
                }
                else if (arr[i] is Teacher)
                {
                    pay = Convert.ToInt32(c.Price + (c.Price * c.T_discount));
                    t++;
                }
                if (arr[i] is Worker)
                {
                    pay = Convert.ToInt32(c.Price);
                    w++;
                }
                sum += pay;
            }

            Console.WriteLine($"Full Earnings of today: {sum}");
            Console.WriteLine($"Price of movie : {c.Price}");
            Console.WriteLine($"Amount of visitors today: {arr.Length}");
            Console.WriteLine($"Amount of Students: {s}");
            Console.WriteLine($"Amount of Teachers: {t}");
            Console.WriteLine($"Amount of Workers: {w}");
        }

        static void Main(string[] args)
        {
            Cinema cinemaCity = new Cinema("Avatar", 80);
            Person[] arr = new Person[15];

            Random r = new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                int x = r.Next(0, 3);
                switch (x)
                {
                    case 0: arr[i] = new Student("Ariel", "Biology", "Dan Gil",21, "324344422",true); break;
                    case 1: arr[i] = new Teacher("Biology", 32, "Guy Alon", 50, "324344422", true); break;
                    case 2: arr[i] = new Worker(50000, "Rona", 21, "324344422", false); break;
                }
            }

            func(arr, cinemaCity);
        }
    }
}
