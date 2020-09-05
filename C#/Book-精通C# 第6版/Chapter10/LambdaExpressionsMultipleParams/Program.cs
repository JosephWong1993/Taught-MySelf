using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //  使用Lambda表达式注册委托
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) =>
            {
                Console.WriteLine("Message: {0},Result: {1}", msg, result);
            });

            m.Add(10, 10);
            Console.ReadLine();
        }
    }
}
