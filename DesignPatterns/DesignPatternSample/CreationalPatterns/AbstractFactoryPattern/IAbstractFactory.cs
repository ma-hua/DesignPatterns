using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.AbstractFactoryPattern
{
    public interface IAbstractFactory
    {
        IProduct CreateProduct(FactoryEnum factoryEnum, ProductEnum productEnum);
    }
}
