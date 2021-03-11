using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.DecoratorPattern.Semi_TransparentPattern
{
    public class ConcreteDecorator : IComponent
    {
        private readonly IComponent _component;
        public ConcreteDecorator(IComponent component) 
        {
            _component = component;
        }
        public void Display()
        {
            _component.Display();
        }

        public void AddBehavior()
        {
            Console.WriteLine("AddBehavior");
        }
    }
}
