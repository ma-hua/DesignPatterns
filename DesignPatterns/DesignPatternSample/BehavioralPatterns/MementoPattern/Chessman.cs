using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.MementoPattern
{
    internal class Chessman
    {
        public Chessman(string label, int x, int y)
        {
            Label = label;
            X = x;
            Y = y;
        }

        internal string Label { get; set; }

        internal int X { get; set; }

        internal int Y { get; set; }

        internal ChessmanMemento Save()
        {
            return new ChessmanMemento(Label, X, Y);
        }

        internal void Restore(ChessmanMemento memento)
        {
            this.Label = memento.Label;
            this.X = memento.X;
            this.Y = memento.Y;
        }
    }
}
