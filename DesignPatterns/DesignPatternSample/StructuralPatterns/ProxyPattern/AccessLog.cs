using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.ProxyPattern
{
    public class AccessLog
    {
        public void Log(string userId) => Console.WriteLine($"data access by {userId}");
    }
}
