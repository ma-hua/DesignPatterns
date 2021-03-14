using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.BehavioralPatterns.CoRPattern
{
    public class RequestContext
    {
        public RequestContext(double amount, int number, string purpose)
        {
            Amount = amount;
            Number = number;
            Purpose = purpose;
        }

        public double Amount { get; set; }

        public int Number { get; set; }

        public string Purpose { get; set; }
    }
}
