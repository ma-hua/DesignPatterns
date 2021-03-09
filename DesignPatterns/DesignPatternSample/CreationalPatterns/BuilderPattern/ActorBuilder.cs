using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.CreationalPatterns.BuilderPattern
{
    /// <summary>
    /// 建造者模式
    /// </summary>
    public class ActorBuilder : IActorBuilder
    {
        protected Actor actor = new Actor();

        public void BuildPartA()
        {
            if (IsBuildPartA())
            {
                actor.BuildPartA("PartA");
            }
        }

        public void BuildPartB()
        {
            if (IsBuildPartB())
            {
                actor.BuildPartB("PartB");
            }
        }

        public void BuildPartC()
        {
            if (IsBuildPartC())
            {
                actor.BuildPartC("PartC");
            }
        }

        public Actor GetActor() => actor;

        public bool IsBuildPartA()
        {
            return true;
        }

        public bool IsBuildPartB()
        {
            return true;
        }

        public bool IsBuildPartC()
        {
            return true;
        }
    }
}
