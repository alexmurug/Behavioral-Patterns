﻿using System.Collections;

namespace InteratorPattern
{
    public class TaxiCollection : ITaxiCollection
    {
        private readonly ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }

    }
}