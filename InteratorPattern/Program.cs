using System;

namespace InteratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            var computerCollection = new TaxiCollection
            {
                [0] = new VIPTaxi("VIP Taxi 1"),
                [1] = new VIPTaxi("VIP Taxi 2"),
                [2] = new VIPTaxi("VIP Taxi 2"),
                [3] = new BusTaxi("BUS TAXI 1"),
                [4] = new BusTaxi("BUS TAXI 2")
            };


            var iterator = computerCollection.CreateIterator();
           

            Console.WriteLine("Collection iteration:\n");

            for (var item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
