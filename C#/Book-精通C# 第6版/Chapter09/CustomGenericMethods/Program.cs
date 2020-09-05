using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with custom Generic methods *****\n");

            //  交换两个整数
            int a = 10, b = 90;
            Console.WriteLine("Befero swap:{0},{1}", a, b);
            MyGenericMethods.Swap<int>(ref a, ref b);
            Console.WriteLine("After swap:{0} {1}", a, b);
            Console.WriteLine();

            //  交换两个字符
            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Befero swap:{0} {1}", s1, s2);
            MyGenericMethods.Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap:{0} {1}", s1, s2);
            Console.WriteLine();

            //  编译器将推断System.Boolen
            bool b1 = true, b2 = false;
            Console.WriteLine("Befero swap:{0} {1}", b1, b2);
            MyGenericMethods.Swap(ref b1, ref b2);
            Console.WriteLine("After swap:{0} {1}", b1, b2);
            Console.WriteLine();

            //  方法没有参数,就必须提供类型参数
            MyGenericMethods.DisplayBaseClass<int>();
            MyGenericMethods.DisplayBaseClass<string>();

            //  编译器错误!没有参数时必须提供占位符
            //  DisplayBaseClass();
            Console.WriteLine();

            Console.ReadLine();
        }

        
    }
}
