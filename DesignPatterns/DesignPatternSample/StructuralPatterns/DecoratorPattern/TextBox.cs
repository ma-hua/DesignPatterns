using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.DecoratorPattern
{
    public class TextBox : IComponent
    {
        public void Display()
        {
            Console.WriteLine("TextBox Display");
        }
    }
}
