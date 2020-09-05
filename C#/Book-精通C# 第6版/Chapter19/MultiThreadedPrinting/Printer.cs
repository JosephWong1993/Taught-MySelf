using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadedPrinting
{
    class Printer
    {
        //  锁标识
        private object threadLock = new object();

        public void PrintNumbers()
        {
            Monitor.Enter(threadLock);
            try
            {
                //  显示Thread信息
                Console.WriteLine("-> {0} is executing PrintNumbers()",
                    Thread.CurrentThread.ManagedThreadId);

                //  输出数字
                Console.WriteLine("Your numbers:");
                for (int i = 0; i < 10; i++)
                {
                    //  使线程休眠数秒
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(5));
                    Console.Write("{0},", i);
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(threadLock);
            }
        }
    }
}
