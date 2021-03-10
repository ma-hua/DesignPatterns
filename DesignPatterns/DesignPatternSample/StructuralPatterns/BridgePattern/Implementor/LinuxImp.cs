using System;


namespace DesignPatternSample.StructuralPatterns.BridgePattern.Implementor
{
    [Imp(ImpType.Linux)]
    public class LinuxImp : ImageImp
    {
        public void DoPaint(Matrix m)
        {
            Console.WriteLine("paint in Linux");
        }
    }
}
