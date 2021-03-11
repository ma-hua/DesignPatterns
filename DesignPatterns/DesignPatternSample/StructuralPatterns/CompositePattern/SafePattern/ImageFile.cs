using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.CompositePattern.SafeCompositePattern
{
    public class ImageFile : ILeafFile
    {
        public void Open()
        {
            Console.WriteLine("ImageFile Open");
        }
    }
}
