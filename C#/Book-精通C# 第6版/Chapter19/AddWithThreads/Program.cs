using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddWithThreads
{
    class Program
    {
        private static AutoResetEvent waitHandle = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine("ID of thread in Main(): {0}",
                Thread.CurrentThread.ManagedThreadId);

            //  建立AddParams对象，将其传给次线程
            AddParams ap = new AddParams(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);

            //  等待，知道收到通知
            waitHandle.WaitOne();
            Console.WriteLine("Other thread is done!");

            Console.ReadLine();
        }

        static void Add(Object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("ID of thread in Add(): {0}",
                    Thread.CurrentThread.ManagedThreadId);

                AddParams ap = data as AddParams;
                Console.WriteLine("{0} + {1} is {2}",
                    ap.a, ap.b, ap.a + ap.b);

                //  通知其他线程，该线程一结束
                waitHandle.Set();
            }
        }
    }
}
