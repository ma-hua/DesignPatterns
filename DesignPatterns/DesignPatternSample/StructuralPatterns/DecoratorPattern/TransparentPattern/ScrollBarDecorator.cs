using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.DecoratorPattern.TransparentPattern
{
    public class ScrollBarDecorator : Decorator
    {
        public ScrollBarDecorator(IComponent component) : base(component){}

        public override void Display()
        {
            this.SetScrollBar();
            base.Display();
        }

        public void SetScrollBar()
        {
            Console.WriteLine("SetScrollBar");
        }
    }
}
