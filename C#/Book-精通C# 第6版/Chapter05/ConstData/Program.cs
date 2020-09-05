using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is : {0}", MyMathClass.PI);

            //错误!不能改变常量
            //MyMathClass.PI=3.14444;

            LocalConstStringVariable();

            Console.WriteLine("***** Fun with Const *****");
            Console.WriteLine("The value of PI is : {0}", MyMathClass.PI);

            Console.ReadLine();
        }

        static void LocalConstStringVariable()
        {
            //  局部常量可以被直接访问
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);

            //错误
            //fixedStr = "This will not work!";

            Console.WriteLine();
        }
    }
}
