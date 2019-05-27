using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    // static class can have only static properties:
    // static functions, static attributes, ctor, etc. 
    static class Calculator
    {
        // static attribute sumOfOperations- ++ each time calc is done.
        private static int sumOfOperations;
        public static int SumOfOperations
        {
            get { return sumOfOperations; }
            set { sumOfOperations = value; }
        }

        // Static constructor:
        static Calculator()
        {
            Console.WriteLine("Static constructor is on...");
        }

        // Static function to calculate:
        public static int calc(int n1,int n2,char operation)
        {
            SumOfOperations++;
            switch (operation)
            {
                case '+': return n1 + n2;
                case '-': return n1 -n2;
                case '/': return n1 / n2;
                case '*': return n1 * n2;
            }
            return 0;
        }



    }
}
