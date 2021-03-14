using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FlyweightPattern
{
    public class WhiteIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "White";
        }
    }
}
