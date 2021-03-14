using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.ExpressionPattern
{
    public interface INode
    {
        int Interpret(int? left = null, int? right = null);
    }
}
