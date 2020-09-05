using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDelegate
{
    //  这个泛型委托可以调用任何返回void并接受单个参数的方法
    public delegate void MyGenericDelegate<T>(T arg);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Generic Delegates *****\n");

            //  注册目标
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<String>(StringTarget);
            strTarget("Some string data");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(9);

            Console.ReadLine();
        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine("++ arg is: {0}", ++arg);
        }
    }
}
