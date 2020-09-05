using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomGenericMethods
{
    public static class MyGenericMethods
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method:{0}", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }

        public static void DisplayBaseClass<T>()
        {
            //  BaseType是反射中使用的一个方法,反射将在第15章中介绍
            Console.WriteLine("Base class of {0} is : {1}", typeof(T), typeof(T).BaseType);
        }
    }
}
