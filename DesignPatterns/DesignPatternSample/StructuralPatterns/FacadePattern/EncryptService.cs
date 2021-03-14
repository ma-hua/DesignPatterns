using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FacadePattern
{
    public class EncryptService : IEncryptService
    {
        private readonly IFileReader fileReader;
        private readonly ICipherMachine cipherMachine;
        private readonly IFileWriter fileWriter;

        public EncryptService(IFileReader fileReader, ICipherMachine cipherMachine, IFileWriter fileWriter)
        {
            this.fileReader = fileReader;
            this.cipherMachine = cipherMachine;
            this.fileWriter = fileWriter;
        }

        public void FileEncrypt(string fileNameSrc, string fileNameDesc)
        {
            var context = fileReader.Read(fileNameSrc);
            var encryptStr = cipherMachine.Encrypt(context);
            fileWriter.Write(encryptStr, fileNameDesc);
        }
    }
}
