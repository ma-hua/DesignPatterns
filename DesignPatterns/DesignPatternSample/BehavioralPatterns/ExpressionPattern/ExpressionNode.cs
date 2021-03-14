using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.ExpressionPattern
{
    public class ExpressionNode : INode
    {
        private Queue<INode> nodes;

        private Queue<int> nums;

        public ExpressionNode(Queue<INode> nodes, Queue<int> nums)
        {
            this.nodes = nodes;
            this.nums = nums;
        }

        public int Interpret(int? left, int? right)
        {
            left = nums.Dequeue();
            while (nodes.Count != 0)
            {
                var node = nodes.Dequeue();
                right = nums.Dequeue();

                left = node.Interpret(left, right);
            }

            return left.Value;
        }
    }
}
