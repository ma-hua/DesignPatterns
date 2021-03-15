using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.MementoPattern
{
    internal class ChessmanMemento
    {
        public ChessmanMemento(string label, int x, int y)
        {
            Label = label;
            X = x;
            Y = y;
        }

        internal string Label { get; set; }

        internal int X { get; set; }

        internal int Y { get; set; }
    }
}
