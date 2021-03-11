using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.CompositePattern.TransparePattern
{
    public class ImageFile : IAbstractFile
    {
        public void Add(IAbstractFile file)
        {
            throw new NotImplementedException();
        }

        public IAbstractFile GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public void Remove(IAbstractFile file)
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            Console.WriteLine("ImageFile Open");
        }

    }
}
