using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncDelegate
{
    class Program
    {
        public delegate int BinaryOp(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("***** Async Delegate Invocation *****");

            //  输出正在执行中的线程的ID
            Console.WriteLine("Main() invoked on thread {0}. ",
                Thread.CurrentThread.ManagedThreadId);

            //  在次线程中调用Add()
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult iftAR = b.BeginInvoke(10, 10, null, null);

            //  在Add()方法完成之前会一直显示消息
            //while (!iftAR.IsCompleted)
            //{
            //    Console.WriteLine("Doing more work in Main()!");
            //    Thread.Sleep(1000);
            //}
            while (!iftAR.AsyncWaitHandle.WaitOne(1000, true))
            {
                Console.WriteLine("Doing more work in Main()!");
            }

            //  当执行完后获取Add()方法的结果
            int answer = b.EndInvoke(iftAR);
            Console.WriteLine("10 + 10 is {0}.", answer);

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
