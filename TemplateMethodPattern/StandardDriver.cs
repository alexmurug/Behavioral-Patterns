using System;

namespace TemplateMethodPattern
{
    public class StandardDriver : HireTaxist
    {
        public override void PayDrive()
        {
            Console.WriteLine("Payind Standar Driver");
        }

        public override void MaitainingCar()
        {
            Console.WriteLine("Maintaing company Car");
        }
    }
}