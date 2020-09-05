using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");

            //  创建一个指向SimpleMath.Add()方法的BinaryOp对象
            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);

            DisplayDelegateInfo(b);

            //  使用委托对象间接调用Add()方法
            //  Invoke()在这里被调用了
            Console.WriteLine("10 + 10 is {0}", b.Invoke(10, 10));

            //  编译器错误!方法不匹配委托的模式
            //BinaryOp b2 = new BinaryOp(SimpleMath.SquareNumber);

            Console.ReadLine();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            //  输出委托调用列表中每个成员的名称
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
    }
}
