using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleMultiThreadApp
{
    public class Printer
    {
        public void PrintNumbers()
        {
            //  显示Thread信息
            Console.WriteLine("-> {0} is excuting PrintNumbers()",
                Thread.CurrentThread.Name);

            //  输出数字
            Console.WriteLine("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}, ", i);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}
