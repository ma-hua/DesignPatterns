using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.BridgePattern.Implementor
{
    [Imp(ImpType.Windows)]
    public class WindowsImp : ImageImp
    {
        public void DoPaint(Matrix matrix)
        {
            Console.WriteLine("paint in Windows");
        }
    }
}
