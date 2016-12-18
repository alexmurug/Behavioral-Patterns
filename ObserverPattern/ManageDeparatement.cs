using System;

namespace ObserverPattern
{
    public class ManageDeparatement : IDepartament
    {
        private readonly string _name;

        public ManageDeparatement(string name)
        {
            _name = name;
        }

        public Taxi Taxi { get; set; }

        public void Update(Taxi taxi)
        {
            Console.WriteLine("{0} ! Notified {1} of {2}'s " + "change to {3:C}", taxi.Message, _name, taxi.Type,
                taxi.Price);
        }
    }
}