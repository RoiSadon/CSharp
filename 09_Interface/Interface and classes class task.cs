using System;

namespace App
{
    interface IFly
    {
        void fly(int speed);
        bool land();
    }

    class Airplane : IFly
    {
        // Attributes:
        public string Pilot { get; set; }
        public string Compamy { get; set; }
        public string Destination { get; set; }


        // implements IFly interface:
        public void fly(int speed)
        {
            throw new NotImplementedException();
        }

        public bool land()
        {
            throw new NotImplementedException();
        }
    }

    class Kite : IFly
    {
        // Attributes:
        public string Color { get; set; }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set {
                if (value > 0)
                { price = value; }
            }
        }

        // implements IFly interface:
        public void fly(int speed)
        {
            throw new NotImplementedException();
        }

        public bool land()
        {
            throw new NotImplementedException();
        }
    }

    class Bird : IFly
    {
        // Attributes:
        public string Type { get; set; }
        private decimal age;

        public decimal Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                { age = value; }
            }
        }

        // implements IFly interface:
        public void fly(int speed)
        {
            throw new NotImplementedException();
        }

        public bool land()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFly[] arr = new IFly[10];
            Random r = new Random();
            for (int i=0;i<arr.Length;i++)
            {                
                int num = r.Next(0, 3);
                arr[i] = createFly(num);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

       public static IFly createFly(int num)
        {
            if (num == 0)
                return new Bird();
            else if (num == 1)
                return new Airplane();
            else if (num == 2)
                return new Kite();
            return new Bird();
        }
    }

}
