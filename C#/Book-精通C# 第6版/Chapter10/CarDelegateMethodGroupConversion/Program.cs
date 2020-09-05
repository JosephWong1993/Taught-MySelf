using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDelegateMethodGroupConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Method Group Conversion *****\n");
            Car c1 = new Car();

            //  注册简单的方法名称
            c1.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            //  注销简单的方法名称
            c1.UnRegisterWithCarEngine(CallMeHere);

            //  没有通知
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.ReadLine();
        }

        static void CallMeHere(string msg)
        {
            Console.WriteLine("=> Message from Car: {0}", msg);
        }
    }
}
