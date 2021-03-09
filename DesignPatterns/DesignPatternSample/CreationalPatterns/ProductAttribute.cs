using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns
{
    public class ProductAttribute : Attribute
    {
        public ProductEnum ProductType { get; set; }

        public ProductAttribute(ProductEnum productEnum)
        {
            ProductType = productEnum;
        }
    }
}
