namespace InteratorPattern
{
    public class VIPTaxi : Item
    {
        private string _name;

        public VIPTaxi(string name)
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