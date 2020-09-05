using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddWithThreadsAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine("ID of thread in Main(): {0}",
                Thread.CurrentThread.ManagedThreadId);
            AddAsync();
            Console.ReadLine();
        }

        private static async Task AddAsync()
        {
            Console.WriteLine("ID of thread in AddAsync(): {0}",
                Thread.CurrentThread.ManagedThreadId);
            AddParams ap = new AddParams(10, 10);
            
            //  从这里开始进入了次线程
            await Sum(ap);
            Console.WriteLine("ID of thread in AddAsync(): {0}",
                Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Other thread is done!");
        }

        static async Task Sum(Object data)
        {
            await Task.Run(() =>
            {
                if (data is AddParams)
                {
                    Console.WriteLine("ID of thread in Sum(): {0}",
                        Thread.CurrentThread.ManagedThreadId);
                    AddParams ap = data as AddParams;
                    Console.WriteLine("{0} + {1} is {2}",
                        ap.a, ap.b, ap.a + ap.b);
                }
            });
        }
    }
}
