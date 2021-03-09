using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.BuilderPattern
{
    interface IActorBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();

        bool IsBuildPartA();
        bool IsBuildPartB();
        bool IsBuildPartC();

        Actor GetActor();
    }
}
