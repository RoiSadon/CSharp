using System;

namespace ConsoleApp6
{
   class ElectronicItems
    {
        // Attributes: 

        // 1. price:
        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value > 0) { price = value; }
            }
        }

        // 2. watt:
        private int watt;
        public int Watt
        {
            get => watt;
            set
            {
                if ((value % 100) == 0)
                { watt = value; }
            }
        }

        // 3. warrantyYears:
        private int warrantyYears;
        public int WarrantyYears
        {
            get => warrantyYears;
            set
            {
                if (value >= 0 && value <= 10)
                { warrantyYears = value; }
            }
        }

        // 4. minutesToCharge:
        private int minutesToCharge;
        public int MinutesToCharge
        {
            get { return minutesToCharge; }
            set
            {
                if (value > 0)
                { minutesToCharge = value; }
            }
        }

        // Constructor:
        public ElectronicItems(decimal price, int watt, int warrantyYears, int minutesToCharge)
        {
            Price = price;
            Watt = watt;
            WarrantyYears = warrantyYears;
            MinutesToCharge = minutesToCharge;
        }

        // Methods:
        public event Action<int> EndChargeEvent;
        public void ChargeItem(int minToCharge)
        {            
            if (MinutesToCharge <= minToCharge)
            {
                EndChargeEvent.Invoke(minToCharge);                
            }          
        }

        public virtual string print_info()
        {
            return $"Price: {Price}, Watt: {Watt}, WarrantyYears: {WarrantyYears}, MinutesToCharge: {MinutesToCharge} ";
        }
    }
}

