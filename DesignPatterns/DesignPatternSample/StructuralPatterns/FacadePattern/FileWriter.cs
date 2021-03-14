using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FacadePattern
{
    public class FileWriter : IFileWriter
    {
        public void Write(string encryptStr, string fileName)
        {
            Console.WriteLine($"write {encryptStr} into {fileName}");
        }
    }
}
