using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Primary Thread stats *****\n");

            //  获取当前线程的名字
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";

            //  显示承载的应用程序域和上下文的详细信息
            Console.WriteLine("Name of current AppDomain:{0}",
                Thread.GetDomain().FriendlyName);
            Console.WriteLine("ID of current Context: {0}",
                Thread.CurrentContext.ContextID);

            //  输出线程的一些信息
            Console.WriteLine("Thread Name: {0}",
                primaryThread.Name);
            Console.WriteLine("Has thread started?: {0}",
                primaryThread.IsAlive);
            Console.WriteLine("Priority Level: {0}",
                primaryThread.Priority);
            Console.WriteLine("Thread State: {0}",
                primaryThread.ThreadState);
            Console.ReadLine();
        }
    }
}
