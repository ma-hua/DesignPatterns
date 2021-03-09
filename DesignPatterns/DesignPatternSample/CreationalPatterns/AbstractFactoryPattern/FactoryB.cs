using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.AbstractFactoryPattern
{
    [Factory(FactoryEnum.FactoryB)]
    public class FactoryB : IFactory
    {
        public readonly IServiceProvider _serviceProvider;

        public FactoryB(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IProduct CreateProduct(ProductEnum productEnum)
        {
            Console.WriteLine("from FactoryB");

            var products = _serviceProvider.GetServices<IProduct>();

            return products.FirstOrDefault(x => x.GetType().GetCustomAttribute<ProductAttribute>()?.ProductType == productEnum);
        }
    }
}
