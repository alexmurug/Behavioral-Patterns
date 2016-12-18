using System;

namespace CommandPattern
{
    public class ExitCommand : TaxiCommand
    {
        public override void Execute()
        {
            Console.WriteLine("The car is now aviable for other orders");
        }
    }
}
