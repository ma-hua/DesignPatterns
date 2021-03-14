using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.CommandPattern
{
    /// <summary>
    /// 消息发送者
    /// </summary>
    public class Invoker
    {
        private CommandQueue commandQueue;

        public Invoker(CommandQueue commandQueue)
        {
            this.commandQueue = commandQueue;
        }

        public void Call(int value)
        {
            commandQueue.Execute(value);
        }
    }
}
