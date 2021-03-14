using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FlyweightPattern
{
    public class BlackIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "Black";
        }
    }
}
