using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.ProxyPattern
{
    public class AccessService : IAccessService
    {
        public string Search(string userId)
        {
            return $"{userId} infos";
        }
    }
}
