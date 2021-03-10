using DesignPatternSample.StructuralPatterns.BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.BridgePattern.Image
{
    public interface IImage
    {
        void SetImp(ImageImp imp);
        void ParseFile(string fileName);
    }
}
