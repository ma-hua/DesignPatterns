using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSample.StructuralPatterns.FlyweightPattern
{
    /// <summary>
    /// 围棋享元工厂
    /// </summary>
    public class IgoChessmanFactory
    {
        private static IgoChessmanFactory instance = new IgoChessmanFactory();
        private Dictionary<string, IgoChessman> obj;

        private IgoChessmanFactory()
        {
            obj = new Dictionary<string, IgoChessman>();

            obj.Add("b", new BlackIgoChessman());

            obj.Add("w", new WhiteIgoChessman());
        }

        public static IgoChessmanFactory GetInstance() => instance;

        public IgoChessman GetIgoChessman(string color) => obj[color];
    }
}
