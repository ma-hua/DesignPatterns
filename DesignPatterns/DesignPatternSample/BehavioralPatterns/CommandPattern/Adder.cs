using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.CommandPattern
{
    /// <summary>
    /// 请求接受者
    /// </summary>
    public class Adder
    {
        private int num;

        public int Add(int value)
        {
            num += value;
            return num;
        }
    }
}
