using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.AbstractFactoryPattern
{
    public interface IFactory
    {
        IProduct CreateProduct(ProductEnum productEnum);
    }
}
