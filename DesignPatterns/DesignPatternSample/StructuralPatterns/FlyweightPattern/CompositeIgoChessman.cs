using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FlyweightPattern
{
    /// <summary>
    /// 复合享元类
    /// </summary>
    public class CompositeIgoChessman : IgoChessman
    {
        private List<IgoChessman> chessmen;
        private readonly string color;

        public CompositeIgoChessman(string color)
        {
            this.color = color;
        }

        public override string GetColor()
        {
            return color;
        }

        public void Add(IgoChessman igoChessman) => chessmen.Add(igoChessman);

        public void Remove(IgoChessman igoChessman) => chessmen.Remove(igoChessman);
    }
}
