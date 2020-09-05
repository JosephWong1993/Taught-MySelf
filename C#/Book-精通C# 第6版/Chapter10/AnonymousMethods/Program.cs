using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Anonymous Methods *****");
            int aboutToBlowCounter = 0;

            //  像平常一样生成一个Car
            Car c1 = new Car("SlugBug", 100, 10);

            //  注册事件处理程序作为匿名方法
            c1.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Eek! Going too fast!");
            };

            c1.AboutToBlow += delegate(Object sender, CarEventArgs e)
            {
                aboutToBlowCounter++;
                Console.WriteLine("Critical Message from Car: {0}", e.msg);
            };

            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Acclerate(20);

            Console.WriteLine("AboutToBlow event was fired {0} times.", aboutToBlowCounter);

            Console.ReadLine();
        }
    }
}
