using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FlyweightPattern
{
    public abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display(Coordinates coordinates)
        {
            Console.WriteLine($"Color: {GetColor()}; X-{coordinates.X}; Y-{coordinates.Y}");
        }
    }
}
