using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");

            //  首先,创建一个Car对象
            Car c1 = new Car("SlugBug", 100, 10);

            //  现在,告诉汽车,他想要向我们发送信息时调用哪个方法
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            //  先绑定委托对象,稍后再注销
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler2);

            //  加速 (这将触发事件)
            Console.WriteLine("***** Speeding Up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            //  注销第二个处理程序
            c1.UnRegisterWithCarEngine(handler2);

            //  看不到大写的消息了
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.ReadLine();
        }

        private static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message Form Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }

        private static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}",msg.ToUpper());
        }
    }
}
