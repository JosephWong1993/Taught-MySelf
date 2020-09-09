using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
