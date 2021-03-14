using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.ExpressionPattern
{
    public class AddNode : INode
    {      
        public int Interpret(int? left, int? right)
        {
            if (!right.HasValue || !left.HasValue)
            {
                throw new Exception("this expression is invalid");
            }
            return left.Value + right.Value;
        }
    }
}
