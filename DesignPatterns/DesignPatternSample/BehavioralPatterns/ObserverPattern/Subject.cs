using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.ObserverPattern
{
    public class Subject : ISubject
    {
        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in Observers)
            {
                observer.Update();
            }
        }
    }
}
