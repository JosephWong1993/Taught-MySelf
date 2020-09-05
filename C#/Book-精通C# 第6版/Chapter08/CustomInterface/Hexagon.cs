using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    class Hexagon : Shape, IPointy,IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public byte Points
        {
            get
            {
                return 6;
            }
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        public byte GetNumberOfPoints()
        {
            return Points;
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexgon in 3D!");
        }
    }
}
