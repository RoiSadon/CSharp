using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop1 = new Shop();
            shop1.supply[0] = new Computer(true, 3000, 1000, 4, 100);
            shop1.supply[1] = new Computer(true, 5000, 1500, 5, 150);
            shop1.supply[2] = new Computer(false, 1500, 1200, 1, 0);
            shop1.supply[3] = new Pelephone(true, "0504342333", 1000, 200, 7, 50);
            shop1.supply[4] = new Pelephone(true, "0203044032", 6000, 500, 2, 20);
            shop1.supply[5] = new Pelephone(false, "0765432345", 1500, 300, 1, 100);


            // First shop:
            Console.WriteLine("-----------Computers supply: ------------");            
            shop1.SuggestSell(1);
            Console.WriteLine(shop1.Sell(0));
            Console.WriteLine("This");
            Console.BackgroundColor = ConsoleColor.Green;
            shop1.supply[0].EndChargeEvent += s => Console.WriteLine($"Charge Time: {s}"); ;
            shop1.supply[0].ChargeItem(120);
            Console.BackgroundColor = ConsoleColor.Black;


            // Second shop:
            Console.WriteLine("-----------Pelephones supply: -----------");
            shop1.SuggestSell(2);            
            Console.WriteLine(shop1.Sell(4));
            Console.BackgroundColor = ConsoleColor.Yellow;
            shop1.supply[4].EndChargeEvent += s => Console.WriteLine($"Charge Time: {s}"); ;
            shop1.supply[4].ChargeItem(70);
            Console.BackgroundColor = ConsoleColor.Black;

            // Send messages: 
            Console.WriteLine("-----Send messages:-----");
            var x = (Pelephone)shop1.supply[4];
            Console.WriteLine(x.send_message(3, "0765432345"));
            Console.WriteLine(x.send_message("How r you?", "0504342333"));
            Console.WriteLine(x.send_message(true, "0765432345"));  
        }
    }
}
