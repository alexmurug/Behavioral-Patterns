namespace InteratorPattern
{
    public class Iterator : IIterator
    {
        private readonly TaxiCollection _taxiCollection;
        private int _current;

        public Iterator(TaxiCollection taxiCollection)
        {
            _taxiCollection = taxiCollection;
        }

        public int Step { get; set; } = 1;

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

        public Item Next()
        {
            _current += Step;

            if (!IsDone)
                return _taxiCollection[_current] as Item;
            return null;
        }
    }
}