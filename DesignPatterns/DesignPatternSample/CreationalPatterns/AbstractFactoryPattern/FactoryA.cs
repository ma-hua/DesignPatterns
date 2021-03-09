using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.AbstractFactoryPattern
{
    [Factory(FactoryEnum.FactoryA)]
    public class FactoryA : IFactory
    {
        public readonly IServiceProvider _serviceProvider;

        public FactoryA(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IProduct CreateProduct(ProductEnum productEnum)
        {
            Console.WriteLine("from FactoryA");

            var products = _serviceProvider.GetServices<IProduct>();

            return products.FirstOrDefault(x => x.GetType().GetCustomAttribute<ProductAttribute>()?.ProductType == productEnum);
        }
    }
}
