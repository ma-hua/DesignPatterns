using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.ObserverPattern
{
    public interface ISubject
    {
        List<IObserver> Observers { get; set; }

        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
