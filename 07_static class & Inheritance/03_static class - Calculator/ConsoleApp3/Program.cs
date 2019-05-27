using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"SumOfOperations{Calculator.SumOfOperations}");

            int n1 = 9, n2 = 3;

            // Examples of calculation:
            Console.WriteLine($"{n1} + {n2} = {Calculator.calc(n1,n2,'+')}");
            Console.WriteLine($"SumOfOperations: {Calculator.SumOfOperations}");

            Console.WriteLine($"{n1} - {n2} = {Calculator.calc(n1, n2, '-')}");
            Console.WriteLine($"SumOfOperations: {Calculator.SumOfOperations}");

            Console.WriteLine($"{n1} / {n2} = {Calculator.calc(n1, n2, '/')}");
            Console.WriteLine($"SumOfOperations: {Calculator.SumOfOperations}");

            Console.WriteLine($"{n1} *{n2} = {Calculator.calc(n1, n2, '*')}");
            Console.WriteLine($"SumOfOperations: {Calculator.SumOfOperations}");

        }

    }
}
