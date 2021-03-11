using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.CompositePattern.SafeCompositePattern
{
    public class TextFile : ILeafFile
    {
        public void Open()
        {
            Console.WriteLine("TextFile Open");
        }
    }
}
