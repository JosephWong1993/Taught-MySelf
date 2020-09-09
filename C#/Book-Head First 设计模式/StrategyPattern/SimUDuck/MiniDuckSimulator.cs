using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class MiniDuckSimulator
    {
        public static void Main(string[] args)
        {
            Duck mallared = new MallardDuck();
            mallared.PerformQuack();
            mallared.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
