namespace InteratorPattern
{
    public class Iterator : IIterator
    {
        private readonly TaxiCollection _taxiCollection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(TaxiCollection taxiCollection)
        {
            _taxiCollection = taxiCollection;
        }

        public Item CurrentItem
        {
            get { return _taxiCollection[_current] as Item; }
        }

        public bool IsDone
        {
            get { return _current >= _taxiCollection.Count; }
        }

        public Item First()
        {
            _current = 0;
            return _taxiCollection[_current] as Item;
        }

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        public Item Next()
        {
            _current += _step;

            if (!IsDone)
                return _taxiCollection[_current] as Item;
            else
                return null;
        }
    }
}