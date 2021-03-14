using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.CommandPattern
{
    public class CommandQueue : ICommand
    {
        private List<ICommand> commands = new List<ICommand>();
        private int result;

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public int Execute(int value)
        {
            foreach(var command in commands)
            {
                result += command.Execute(value);
            }

            return result;
        }

        public void RemoveCommand(ICommand command)
        {
            commands.Remove(command);
        }

        public int Undo()
        {
            foreach(var command in commands)
            {
                result = command.Undo();
            }

            return result;
        }
    }
}
