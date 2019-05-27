using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Computer : ElectronicItems
    {
        // Attributes:
        public bool IsPortable { get; set; }

        // Constructor:
        public Computer(bool isPortable, decimal price, int watt, int warrantyYears, int minutesToCharge) : base(price, watt, warrantyYears, minutesToCharge)
        {
            IsPortable = isPortable;
        }

        // Methods:
        public override string print_info()
        {
            return base.print_info() + $"IsPortable: {IsPortable}";
        }
        
    }
}
