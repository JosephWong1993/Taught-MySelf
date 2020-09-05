using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Generic Structures *****\n");

            //  使用整数的Point
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine("p.ToString()={0}", p.ToString());
            p.ResetPoint();
            Console.WriteLine("p.ToString()={0}", p.ToString());
            Console.WriteLine();


            //  使用双精度数的Point
            Point<double> p2 = new Point<double>(5.4, 3.3);
            Console.WriteLine("p.ToString()={0}", p2.ToString());
            p2.ResetPoint();
            Console.WriteLine("p.ToString()={0}", p2.ToString());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
