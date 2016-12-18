namespace InteratorPattern
{
    public class BusTaxi : Item
    {
        private string _name;

        public BusTaxi(string name)
        {
            _name = name;
        }

        public override string Name
        {
            get { return _name; }

            set { _name = value; }
        }
    }
}