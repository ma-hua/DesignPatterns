using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.CompositePattern.TransparePattern
{
    public interface IAbstractFile
    {
        void Add(IAbstractFile file);
        void Remove(IAbstractFile file);
        IAbstractFile GetChild(int i);
        void Open();
    }
}
