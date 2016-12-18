using System;

namespace CommandPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var taxiFunction = new TaxiFunction();
            TaxiCommand driveCommand = new DriveCommand(taxiFunction);
            TaxiCommand senCommand = new SendCommand();
            TaxiCommand exitCommand = new ExitCommand();

            var invoker = new TaxiInvoker();

            invoker.SetCommand(senCommand);
            invoker.ExecuteCommand();

            invoker.SetCommand(driveCommand);
            invoker.ExecuteCommand();

            invoker.SetCommand(exitCommand);
            invoker.ExecuteCommand();


            Console.ReadKey();
        }
    }
}