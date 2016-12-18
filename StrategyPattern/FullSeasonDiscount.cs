using System;

namespace StrategyPattern
{
    public class FullSeasonDiscount : PriceStrategy
    {
        public override void AlgorithmCalculatings(int price)
        {
            Console.WriteLine("Full season discount is " + price*0.03 + " on Bus Taxi");
            Console.WriteLine("Full season discount is " + price*0.05 + " on Standard Taxi");
            Console.WriteLine("Full season discount is " + price*0.07 + " on Vip Taxi");
        }
    }
}