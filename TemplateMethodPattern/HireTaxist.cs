using System;

namespace TemplateMethodPattern
{
    public abstract class HireTaxist
    {
        protected HireTaxist()
        {
            SearchDrive();
            BuyCar();
            SignAgreement();
        }

        public void SearchDrive()
        {
            Console.WriteLine("Searching candidate...");
        }

        public void BuyCar()
        {
            Console.WriteLine("Buying new Car...");
        }

        public void SignAgreement()
        {
            Console.WriteLine("SignAgremment...");
        }

        public abstract void PayDrive();
        public abstract void MaitainingCar();

        public void MonthAction()
        {
            PayDrive();
            MaitainingCar();
        }
    }
}