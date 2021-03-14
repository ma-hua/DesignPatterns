using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.CommandPattern
{

    public class AddCommand : ICommand
    {
        private Adder adder = new Adder();
        private int value;

        public int Execute(int value)
        {
            this.value = value;
            return adder.Add(value);
        }

        public int Undo()
        {
            return adder.Add(-value);
        }
    }
}
