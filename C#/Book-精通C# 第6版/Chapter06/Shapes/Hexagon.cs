﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }
}
