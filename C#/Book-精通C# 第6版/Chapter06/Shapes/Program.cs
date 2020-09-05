using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };

            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.WriteLine();

            //调用了ThreeDCircle的Draw()方法
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();

            //调用了父类的Draw()方法
            ((Circle)o).Draw();

            Console.ReadLine();
        }
    }
}
