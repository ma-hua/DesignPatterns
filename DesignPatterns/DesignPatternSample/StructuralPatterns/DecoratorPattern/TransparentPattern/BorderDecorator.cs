using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.DecoratorPattern.TransparentPattern
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(IComponent component) : base(component) { }

        public override void Display()
        {
            this.SetBorder();
            base.Display();
        }

        public void SetBorder()
        {
            Console.WriteLine("SetBorder");
        }
    }
}
