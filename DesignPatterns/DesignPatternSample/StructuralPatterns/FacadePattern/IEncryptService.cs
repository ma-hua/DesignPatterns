using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FacadePattern
{
    public interface IEncryptService
    {
        void FileEncrypt(string fileNameSrc, string fileNameDesc);
    }
}
