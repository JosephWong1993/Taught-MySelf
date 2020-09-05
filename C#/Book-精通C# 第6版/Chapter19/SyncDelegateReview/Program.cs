using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SyncDelegateReview
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("***** Sync Delegate Review *****");

            //  输出正在执行中的线程ID
            Console.WriteLine("Main() invoked on thread {0}.",
                Thread.CurrentThread.ManagedThreadId);

            //  在同步模式下调用Add();
            BinaryOp b = new BinaryOp(Add);

            //  也能写b.Invoke(10,10)
            int answer = b(10, 10);

            //  直到Add()方法完成后，这行代码才会执行
            Console.WriteLine("Doing more work in Main()!");
            Console.WriteLine("10+10 is {0}.", answer);
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            //  输出正在执行中的线程ID
            Console.WriteLine("Add() invoked on thread {0}.",
                Thread.CurrentThread.ManagedThreadId);

            //  暂停一下，模拟一个耗时的操作
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
