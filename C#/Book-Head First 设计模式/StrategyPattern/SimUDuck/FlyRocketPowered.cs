using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    /// <summary>
    /// 我们建立一个利用火箭动力的飞行行为
    /// </summary>
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
