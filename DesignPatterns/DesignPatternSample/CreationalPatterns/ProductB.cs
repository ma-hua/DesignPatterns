using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns
{
    [ProductAttribute(ProductEnum.ProductB)]
    public class ProductB : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("this is ProductB");
        }
    }
}
