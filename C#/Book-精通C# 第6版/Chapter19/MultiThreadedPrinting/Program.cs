using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadedPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Synchronizing Threads *****\n");
            Printer p = new Printer();

            //  使10个线程全部指向同一对象的同一方法
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
                threads[i].Name = string.Format("Worker thread #{0}", i);
            }

            //  现在开始每一个线程
            foreach (Thread t in threads)
            {
                t.Start();
            }
            Console.ReadLine();
        }
    }
}
