using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.IteratorPattern
{
    public class ListIterator<T> : Iterator<T>
    {
        private T[] Items;
        private int index;

        public ListIterator(T[] items)
        {
            Items = items;
        }

        public T CurrentItem() => Items[index];

        public bool MoveNext()
        {
            if (++index >= Items.Length)
                return false;
            return true;
        }
    }
}
