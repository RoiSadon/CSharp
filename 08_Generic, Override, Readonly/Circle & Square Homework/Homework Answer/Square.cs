using System;

namespace Homework_Answer
{
    // This class will describe an Circle:
    class Square
    {

        // Attributes:
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        private double edgeOfSquare;
        public double EdgeOfSquare
        {
            get => edgeOfSquare;
            set
            {
                if (value > 0)
                { edgeOfSquare = value; }
            }
        }

        // Methods:

        // Constructor:
        public Square(int x, int y, string color, double edgeOfSquare)
        {
            X = x;
            Y = y;
            Color = color;
            EdgeOfSquare = edgeOfSquare;
            System.Console.WriteLine("A Square has been created");
        }

        // Print info: 
        public string print_info()
        {
            return $"X: {X}, Y: {Y}, Color:{Color}, EdgeOfSquare: {EdgeOfSquare} ";
        }

        // Return area of Square: 
        public double Area_of_circle()
        {
            double area = EdgeOfSquare * EdgeOfSquare;
            return area;
        }

        // Return scope of Square: 
        public double Scope_of_circle()
        {
            double scope = EdgeOfSquare*4;
            return scope;
        }
    }
}
