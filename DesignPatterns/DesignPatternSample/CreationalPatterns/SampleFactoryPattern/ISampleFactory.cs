using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.SampleFactoryPattern
{
    public interface ISampleFactory
    {
        IProduct CreateProduct(ProductEnum productEnum);
    }
}
