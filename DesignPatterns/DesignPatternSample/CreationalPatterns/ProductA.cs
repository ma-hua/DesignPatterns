using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns
{
    [ProductAttribute(ProductEnum.ProductA)]
    public class ProductA : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("this is ProductA");
        }
    }
}
