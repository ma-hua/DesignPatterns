using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.BridgePattern
{
    public class Matrix
    {
        public string FileName { get; set; }

        public Matrix(string fileName)
        {
            FileName = fileName;
        }
    }
}
