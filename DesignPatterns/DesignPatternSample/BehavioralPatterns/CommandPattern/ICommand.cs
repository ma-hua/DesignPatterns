using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.CommandPattern
{
    public interface ICommand
    {
        int Execute(int value);

        int Undo();
    }
}
