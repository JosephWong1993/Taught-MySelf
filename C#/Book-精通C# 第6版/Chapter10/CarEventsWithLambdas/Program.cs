using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarEventsWithLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("More Fun with Lambdas *****\n");

            //  像平常一样创建一个Car对象
            Car c1 = new Car("SlugBug", 100, 10);

            //  使用Lambada表达式挂接事件
            c1.AboutToBlow += (sender, e) =>
            {
                Console.WriteLine(e.msg);
            };
            c1.Exploded += (sender, e) =>
            {
                Console.WriteLine(e.msg);
            };

            //  加速 (这会触发事件)
            Console.WriteLine("\n***** Speeding up *****");

            for (int i = 0; i < 6; i++)
            {
                c1.Acclerate(20);
            }

            Console.ReadLine();
        }
    }
}
