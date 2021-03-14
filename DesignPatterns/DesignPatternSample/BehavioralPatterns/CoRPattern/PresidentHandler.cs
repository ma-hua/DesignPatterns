using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.CoRPattern
{
    public class PresidentHandler : ApproveHandler
    {
        public PresidentHandler(string name) : base(name) { }

        public override void ProcessRequest(RequestContext context)
        {
            Console.WriteLine($"president approve this work order. Amount-{context.Amount}; Number-{context.Number}; Purpose-{context.Purpose};");
        }
    }
}
