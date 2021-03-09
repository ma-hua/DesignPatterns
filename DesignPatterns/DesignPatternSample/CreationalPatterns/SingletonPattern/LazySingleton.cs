using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.SingletonPattern
{
    /// <summary>
    /// 懒汉模式
    /// </summary>
    public class LazySingleton
    {
        private static LazySingleton instance = null;

        private LazySingleton() { }

        private static readonly object syncRoot = new object();

        public static LazySingleton GetInstance()
        {
            if(instance == null)
            {
                lock (syncRoot)
                {
                    if(instance == null)
                    {
                        instance = new LazySingleton();
                    }
                }
            }

            return instance;
        }
    }
}
