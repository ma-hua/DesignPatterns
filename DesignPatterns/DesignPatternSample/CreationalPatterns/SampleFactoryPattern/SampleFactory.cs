using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace DesignPatternSample.CreationalPatterns.SampleFactoryPattern
{
    /// <summary>
    /// 工厂模式
    /// </summary>
    public class SampleFactory : ISampleFactory
    {
        public readonly IServiceProvider _serviceProvider;

        public SampleFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IProduct CreateProduct(ProductEnum productEnum)
        {
            var products = _serviceProvider.GetServices<IProduct>();

            return products.FirstOrDefault(x => x.GetType().GetCustomAttribute<ProductAttribute>()?.ProductType == productEnum);
        }
    }
}
