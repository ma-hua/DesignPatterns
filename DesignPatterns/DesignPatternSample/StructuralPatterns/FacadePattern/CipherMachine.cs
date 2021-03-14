using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FacadePattern
{
    public class CipherMachine : ICipherMachine
    {
        public string Encrypt(string plainText)
        {
            Console.WriteLine($"Encrypt {plainText}");
            return $"Encrypt {plainText}";
        }
    }
}
