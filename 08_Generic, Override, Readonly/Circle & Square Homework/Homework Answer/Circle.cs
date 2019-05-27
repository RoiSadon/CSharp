using System;

namespace Homework_Answer
{
    // This class will describe an Circle:
    class Circle
    {

        // Attributes:
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                if (value > 0)
                { radius = value; }
            }
        }

        // Methods:
        
        // Constructor:
        public Circle(int x, int y, string color, double radius)
        {
            X = x;
            Y = y;
            Color = color;
            Radius = radius;
            System.Console.WriteLine("A circle has been created");
        }

        // Print info: 
        public string print_info()
        {
            return $"X: {X}, Y: {Y}, Color:{Color}, Radius: {Radius} ";
        }

        // Return area of circle: 
        public double Area_of_circle()
        {          
            double pi = Math.PI;
            double area = pi * (Radius * Radius);
            return area;
        }

        // Return scope of circle: 
        public double Scope_of_circle()
        {
            double pi = Math.PI;
            double scope = pi * Radius * 2;
            return scope;
        }





    }
}
