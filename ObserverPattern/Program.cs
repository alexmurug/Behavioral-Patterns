using System;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var taxiCompany = new TaxiCompany("Seven Taxi", 150, "Full season offert");
            taxiCompany.Attach(new ManageDeparatement("Manage departament"));
            taxiCompany.Attach(new DispatchDepartament("Dispatch departament"));

            taxiCompany.Price = 60;
            taxiCompany.Price = 70;
            taxiCompany.Price = 90;

            taxiCompany.Message = "Winter offert";

            Console.ReadKey();
        }
    }
}
