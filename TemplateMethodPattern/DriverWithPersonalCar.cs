using System;

namespace TemplateMethodPattern
{
    public class DriverWithPersonalCar : HireTaxist
    {
        public override void PayDrive()
        {
            Console.WriteLine("Payin Driver with personal Car");
        }

        public override void MaitainingCar()
        {
            Console.WriteLine("The Company does not bear the cost of maintenance of personal car");
        }
    }
}