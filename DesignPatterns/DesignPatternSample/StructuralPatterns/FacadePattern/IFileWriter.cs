using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FacadePattern
{
    public interface IFileWriter
    {
        void Write(string encryptStr, string fileName);
    }
}
