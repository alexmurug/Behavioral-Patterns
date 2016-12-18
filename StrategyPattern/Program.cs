using System;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var strategyContext = new StrategyContext(new FullSeasonDiscount());
            strategyContext.ContextInterface(100);

            Console.WriteLine();

            strategyContext = new StrategyContext(new WinterDiscount());
            strategyContext.ContextInterface(100);

            Console.WriteLine();

            strategyContext = new StrategyContext(new MerryChristmasDiscount());
            strategyContext.ContextInterface(100);


            Console.ReadKey();
        }
    }
}