using System;

namespace StrategyPattern
{
    public class WinterDiscount : PriceStrategy
    {
        public override void AlgorithmCalculatings(int price)
        {
            Console.WriteLine("Winter discount is " + price*0.10 + " on Bus Taxi");
            Console.WriteLine("Winter discount is " + price*0.15 + " on Standard Taxi");
            Console.WriteLine("Winter discount is " + price*0.20 + " on VIP Taxi");
        }
    }
}