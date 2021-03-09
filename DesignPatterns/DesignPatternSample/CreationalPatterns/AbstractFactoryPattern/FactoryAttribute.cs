using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.AbstractFactoryPattern
{
    public class FactoryAttribute : Attribute
    {
        public FactoryEnum FactoryType { get; set; }

        public FactoryAttribute(FactoryEnum factoryType)
        {
            FactoryType = factoryType;
        }
    }
}
