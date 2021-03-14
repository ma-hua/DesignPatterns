using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.IteratorPattern
{
    public class MockList<T> : IMockList<T>
    {
        private T[] items = new T[16];
        public int Count { get; set; }

        public Iterator<T> GetIterator()
        {
            return new ListIterator<T>(items);
        }

        public void Add(T item)
        {
            if(++Count >= items.Length)
            {
                EnsureCapacity();
            }

            items[Count] = item;
        }

        public bool Remove(T item)
        {
            var index = IndexOf(item);
            if (index >= 0)
            {
                Array.Copy(items, index + 1, items, index, Count - index);
                Count--;
                return true;
            }

            return false;
        }

        private void EnsureCapacity()
        {
            var array = new T[items.Length * 2];
            Array.Copy(items, 0, array, 0, Count);
            items = array;
        }

        public int IndexOf(T item)
        {
            for(int i = 0; i< Count; i++)
            {
                if (items[i].Equals(item) )
                    return i;
            }

            return -1;
        }
    }
}
