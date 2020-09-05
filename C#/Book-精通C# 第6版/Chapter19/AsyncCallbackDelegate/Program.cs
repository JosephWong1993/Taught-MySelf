using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace AsyncCallbackDelegate
{
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        private static bool isDone = false;
        static void Main(string[] args)
        {
            Console.WriteLine("***** AsyncCallBackDelegate Example *****");
            Console.WriteLine("Main() invoked on thread {0}. ",
                Thread.CurrentThread.ManagedThreadId);

            BinaryOp b = new BinaryOp(Add);
            IAsyncResult itfAR = b.BeginInvoke(10, 10, 
                new AsyncCallback(AddComplete), 
                "Main() thanks you for adding these numbers.");

            //  这里可以做其他事情
            while (!isDone)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Working...");
            }
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}. ",
                Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }

        //  不要忘记导入System.Runtime.Remoting.Messaging
        static void AddComplete(IAsyncResult itfAR)
        {
            Console.WriteLine("AddComplete() invoked on thread {0}.",
                Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Your addition is complete");

            //  现在得到结果
            AsyncResult ar = itfAR as AsyncResult;
            BinaryOp b = ar.AsyncDelegate as BinaryOp;
            Console.WriteLine("10 + 10 is {0}.", b.EndInvoke(itfAR));

            //  获取消息对象，并转换成string
            string msg = (string)itfAR.AsyncState;
            Console.WriteLine(msg);
            isDone = true;
        }
    }
}
