using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.ProxyPattern
{
    public class AccessValidator
    {
        public bool Validate(string userId) => userId == "admin";
    }
}
