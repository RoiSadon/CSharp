namespace ConsoleApp6
{
    internal class Pelephone : ElectronicItems
    {
        // Attributes:
        // IsSmartphone:
        public bool IsSmartphone { get; set; }

        // phoneNumber:
        private string phoneNumber;
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                int num;
                if(value.Length==10 && int.TryParse(value,out num))
                { phoneNumber = value; }
            }
        }

        // Constructor:
        public Pelephone(bool isSmartphone, string phoneNumber, decimal price, int watt, int warrantyYears, int minutesToCharge) : base(price, watt, warrantyYears, minutesToCharge)
        {
            IsSmartphone = isSmartphone;
            PhoneNumber = phoneNumber;
        }

        // Methods:
        // print_info:
        public override string print_info()
        {
            return base.print_info() + $"IsSmartphone: {IsSmartphone}, PhoneNumber: {PhoneNumber} ";
        }

        // send message:
        public string send_message<T>(T msg,string phoneNum) 
        {
            return $"FROM: {PhoneNumber} msg: {msg}, TO: {phoneNum}";
        }

    }
}
