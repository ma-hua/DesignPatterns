using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.DecoratorPattern
{
    public class ListBox : IComponent
    {
        public void Display()
        {
            Console.WriteLine("ListBox Display");
        }
    }
}
