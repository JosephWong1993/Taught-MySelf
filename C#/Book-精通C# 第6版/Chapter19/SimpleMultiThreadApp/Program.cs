using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SimpleMultiThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Amazing Thread App *****\n");
            Console.WriteLine("Do you want [1] or [2] Threads?");
            string threadCount = Console.ReadLine();

            //  命名当前线程
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            //  显示线程的信息
            Console.WriteLine("-> {0} is executing Main()",
                Thread.CurrentThread.Name);

            //  创建执行任务的类
            Printer p = new Printer();

            switch (threadCount)
            {
                case "2":
                    //  设置线程
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Secondary";                    
                    backgroundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("I don't know what you want...you get 1 thread.");
                    goto case "1";
            }

            MessageBox.Show("I'm busy!", "Work on main thread...");
            Console.ReadLine();
        }
    }
}
