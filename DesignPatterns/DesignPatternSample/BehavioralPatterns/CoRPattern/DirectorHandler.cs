using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.CoRPattern
{
    public class DirectorHandler : ApproveHandler
    {
        public DirectorHandler(string name): base(name) { }

        public override void ProcessRequest(RequestContext context)
        {
            if(context.Amount <= 5000)
            {
                Console.WriteLine($"director approve this work order. Amount-{context.Amount}; Number-{context.Number}; Purpose-{context.Purpose};");
                return;
            }

            next.ProcessRequest(context);
        }
    }
}
