using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //answer 2.2,2.3
            Cookie cookie1 = new Cookie();
            cookie1.Gloten=true;
            cookie1.Num_of_eggs = 5;
            cookie1.Sugar = 3;
            cookie1.Flour = 23;

            Cookie cookie2 = new Cookie();
            cookie2.Gloten = false;
            cookie2.Num_of_eggs = 6;
            cookie2.Sugar = 0;
            cookie2.Flour = 30;

            //answer 2.5
            Console.WriteLine("answer 2.5:");
            print_details(cookie1);
            print_details(cookie2);

            //answer 2.6
            cookie1.Sugar = 2;

            //answer 2.7
            Console.WriteLine("answer 2.7:");
            print_details(cookie1);
            print_details(cookie2);

            //answer 2.8
            cookie2 = cookie1;

            //answer 2.9
            cookie2.Num_of_eggs = 5;
            //the change in cookie2 will change also in cookie1

            //answer 2.10
            Console.WriteLine("answer 2.10:");
            print_details(cookie1);
            print_details(cookie2);



        }

        //answer 2.4
        public static void print_details(Cookie c)
        {
            Console.WriteLine("Details of cookie:");
            Console.WriteLine($"Gloten: {c.Gloten}");
            Console.WriteLine($"Number of eggs: {c.Num_of_eggs}");
            Console.WriteLine($"Sugar in gram: {c.Sugar}");
            Console.WriteLine($"Flour in gram: {c.Flour}");
            Console.WriteLine("");
        }
    }
}
