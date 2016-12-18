using System;

namespace StrategyPattern
{
    public class MerryChristmasDiscount : PriceStrategy
    {
        public override void AlgorithmCalculatings(int price)
        {
            Console.WriteLine("Merry Christmas discount is " + price * 0.22 + " on Bus Taxi");
            Console.WriteLine("Merry Christmas discount is " + price * 0.33 + " on Standard Taxi");
            Console.WriteLine("Merry Christmas discount is " + price * 0.44 + " on VIP Taxi");
        }
    }
}
