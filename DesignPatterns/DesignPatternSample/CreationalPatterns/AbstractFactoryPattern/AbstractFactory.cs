using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.AbstractFactoryPattern
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public class AbstractFactory : IAbstractFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public AbstractFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IProduct CreateProduct(FactoryEnum factoryEnum, ProductEnum productEnum)
        {
            var factorys = _serviceProvider.GetServices<IFactory>();

            return factorys.FirstOrDefault(x => x.GetType().GetCustomAttribute<FactoryAttribute>()?.FactoryType == factoryEnum)?.CreateProduct(productEnum);
        }
    }
}
