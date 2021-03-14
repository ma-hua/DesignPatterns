using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.IteratorPattern
{
    public interface Iterator<out T>
    {    
        bool MoveNext();
        T CurrentItem();
    }
}
