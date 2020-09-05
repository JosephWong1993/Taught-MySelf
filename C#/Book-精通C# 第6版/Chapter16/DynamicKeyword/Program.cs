using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace DynamicKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //  a为List<int>类型
            var a = new List<int>();
            a.Add(90);

            //  下面这一行将导致编译时错误
            //  a="Hello";

            PrintThreeStrings();

            ChangeDynamicDataType();

            InvokeMembersOnDynamicData();

            Console.ReadLine();
        }

        static void PrintThreeStrings()
        {
            var s1 = "Greetings";
            object s2 = "Form";
            dynamic s3 = "Minneapolis";

            Console.WriteLine("s1 is of type: {0}", s1.GetType());
            Console.WriteLine("s2 is of type: {0}", s2.GetType());
            Console.WriteLine("s3 is of type: {0}", s3.GetType());
        }

        static void ChangeDynamicDataType()
        {
            //  声明一个名为t的动态数据点
            dynamic t = "Hello!";
            Console.WriteLine("t is of type: {0}", t.GetType());
            t = false;
            Console.WriteLine("t is of type: {0}", t.GetType());
            t = new List<int>();
            Console.WriteLine("t is of type: {0}", t.GetType());
        }

        static void InvokeMembersOnDynamicData()
        {
            dynamic textData1 = "Hello";

            try
            {
                Console.WriteLine(textData1.ToUpper());
                Console.WriteLine(textData1.toupper());
                Console.WriteLine(textData1.Foo(10, "ee", DateTime.Now));
            }
            catch (RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
