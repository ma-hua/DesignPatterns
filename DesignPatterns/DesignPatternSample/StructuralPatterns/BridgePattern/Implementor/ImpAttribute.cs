using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.BridgePattern.Implementor
{
    public class ImpAttribute : Attribute
    {
        public ImpType ImpType { get; set; }

        public ImpAttribute(ImpType impType)
        {
            ImpType = impType;
        }
    }
}
