using System;

namespace TemplateMethodPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HireTaxist staandardTaxist = new StandardDriver();
            staandardTaxist.MonthAction();

            Console.WriteLine();

            HireTaxist driverWithPersonalCar = new DriverWithPersonalCar();
            driverWithPersonalCar.MonthAction();

            Console.ReadKey();
        }
    }
}