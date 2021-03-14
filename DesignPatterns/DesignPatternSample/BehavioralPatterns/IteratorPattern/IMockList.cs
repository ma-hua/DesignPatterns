using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.IteratorPattern
{
    public interface IMockList<T>
    {
        void Add(T item);

        bool Remove(T item);

        Iterator<T> GetIterator();

        int IndexOf(T item);
    }
}
