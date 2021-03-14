using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FacadePattern
{
    public interface IFileReader
    {
        string Read(string fileName);
    }
}
