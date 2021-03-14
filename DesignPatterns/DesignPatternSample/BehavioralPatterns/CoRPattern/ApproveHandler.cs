using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.CoRPattern
{
    public abstract class ApproveHandler
    {
        protected ApproveHandler next;
        protected string name;

        public ApproveHandler(string name) : this(name, null) {}

        public ApproveHandler(string name, ApproveHandler handler)
        {
            this.name = name;
            this.next = handler;
        }

        public void SetNextApproveHandler(ApproveHandler handler) => next = handler;

        public abstract void ProcessRequest(RequestContext context);
    }
}
