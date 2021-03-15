using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.MementoPattern
{
    public class MementoCaretaker
    {
        private List<ChessmanMemento> mementos = new List<ChessmanMemento>();

        internal ChessmanMemento Restore()
        {
            if (mementos.Count == 0)
                return null;

            mementos.RemoveAt(mementos.Count - 1);
            if (mementos.Count == 0)
                return null;

            return mementos[mementos.Count - 1];
        }

        internal void SetMemento(ChessmanMemento memento)
        {
            this.mementos.Add(memento);
        }
    }
}
