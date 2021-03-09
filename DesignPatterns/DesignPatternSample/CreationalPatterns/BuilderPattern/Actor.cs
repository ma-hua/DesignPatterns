using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.BuilderPattern
{
    public class Actor
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string PartC { get; set; }


        public void BuildPartA(string context)
        {
            PartA = context;
        }

        public void BuildPartB(string context)
        {
            PartB = context;
        }

        public void BuildPartC(string context)
        {
            PartC = context;
        }
    }
}
