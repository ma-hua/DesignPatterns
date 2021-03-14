using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FacadePattern
{
    public interface ICipherMachine
    {
        string Encrypt(string plainText);
    }
}
