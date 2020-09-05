using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with Timer type *****");

            //  为Timer类型创建委托
            TimerCallback timeCB = new TimerCallback(PrintTime);

            //  设置Timer类
            Timer t = new Timer(
                timeCB, //  TimerCallback委托类型
                "Hello From Main",   //  想传入的参数（null表示没有参数）
                0,      //  在开始之前，等待多长时间（以毫秒为单位）
                1000);  //  每次调用的间隔时间（以毫秒为单位）
            Console.WriteLine("Hit key to terminate...");
            Console.ReadLine();
        }

        static void PrintTime(object state)
        {
            Console.WriteLine("Time is： {0},Param is: {1}",
                DateTime.Now.ToLongTimeString(),
                state.ToString());
        }
    }
}
