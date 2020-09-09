using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
