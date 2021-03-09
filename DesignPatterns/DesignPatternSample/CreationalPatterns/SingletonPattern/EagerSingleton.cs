using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.SingletonPattern
{
    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class EagerSingleton
    {
        private static EagerSingleton instance = new EagerSingleton();

        private EagerSingleton() { }

        public static EagerSingleton GetInstance() => instance;
    }
}
