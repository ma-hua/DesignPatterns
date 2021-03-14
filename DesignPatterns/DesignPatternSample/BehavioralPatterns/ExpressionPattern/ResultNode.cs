using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.ExpressionPattern
{
    public class ResultNode : INode
    {    
        public int Interpret(int? left, int? right)
        {
            if (!left.HasValue)
            {
                throw new Exception("this expression is invalid");
            }
            return left.Value;
        }
    }
}
