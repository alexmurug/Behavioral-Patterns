using System;

namespace CommandPattern
{
    public class SendCommand : TaxiCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Your order is accepted...");
        }
    }
}
