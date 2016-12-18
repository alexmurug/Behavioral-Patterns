using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class Taxi
    {
        private readonly List<IDepartament> _departaments = new List<IDepartament>();
        private string _message;
        private double _price;

        public Taxi(string type, double price, string message)
        {
            Type = type;
            _price = price;
            _message = message;
        }

        public double Price
        {
            get { return _price; }

            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;

                foreach (var departament in _departaments)
                    if (departament.GetType().Name.Equals("DispatchDepartament"))
                        departament.Update(this);
            }
        }

        public string Type { get; }

        public void Attach(IDepartament departament)
        {
            _departaments.Add(departament);
        }

        public void Detach(IDepartament departament)
        {
            _departaments.Remove(departament);
        }

        public void Notify()
        {
            foreach (var departament in _departaments)
                departament.Update(this);

            Console.WriteLine("");
        }
    }
}