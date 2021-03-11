using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.CompositePattern.SafeCompositePattern
{
    public interface IFolderFile : IAbstractFile
    {
        void Add(IAbstractFile file);
        void Remove(IAbstractFile file);
        IAbstractFile GetChild(int i);
    }
}
