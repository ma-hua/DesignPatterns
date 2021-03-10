using DesignPatternSample.StructuralPatterns.BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.BridgePattern.Image
{
    public class PNGImage : IImage
    {
        protected ImageImp _imageImp;

        public void SetImp(ImageImp imp)
        {
            _imageImp = imp;
        }

        public void ParseFile(string fileName)
        {
            var matrix = new Matrix(fileName);
            _imageImp?.DoPaint(matrix);
            Console.WriteLine(fileName + ".PNG");
        }
    }
}
