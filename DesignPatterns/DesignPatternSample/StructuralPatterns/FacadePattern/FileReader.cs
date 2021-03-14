using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FacadePattern
{
    public class FileReader : IFileReader
    {
        public string Read(string fileName)
        {
            Console.WriteLine($"get context from {fileName}");
            return "context";
        }
    }
}
