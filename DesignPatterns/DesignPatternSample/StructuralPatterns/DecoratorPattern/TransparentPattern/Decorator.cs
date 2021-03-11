using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.DecoratorPattern.TransparentPattern
{
    public abstract class Decorator : IComponent
    {
        private readonly IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public virtual void Display()
        {
            _component.Display();
        }
    }
}
