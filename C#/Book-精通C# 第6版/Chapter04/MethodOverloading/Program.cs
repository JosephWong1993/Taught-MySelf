using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Method Overloading *****\n");

            Console.WriteLine(Add(10, 10));

            Console.WriteLine(Add(9000000000, 900000000));

            Console.WriteLine(Add(4.3, 4.4));

            Console.ReadLine();
        }

        //重载Add方法
        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
