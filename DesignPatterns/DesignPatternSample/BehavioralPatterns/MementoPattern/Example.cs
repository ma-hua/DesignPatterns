using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.MementoPattern
{
    public class Example
    {
        static MementoCaretaker mc = new MementoCaretaker();
        public void Test()
        {
            Chessman chessman = new Chessman("车", 1, 1);
            mc.SetMemento(chessman.Save());

            chessman.Y = 5;
            mc.SetMemento(chessman.Save());

            chessman.Restore(mc.Restore());
        }
    }
}
