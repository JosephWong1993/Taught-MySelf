using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");
            //  使用Action<>委托来指向DisplayMessage
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);

            Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
            string sum = funcTarget2(90, 300);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        //  Action<>委托的一个目标
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            //  设置命令行文本的颜色
            ConsoleColor pervious = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            //  重置颜色
            Console.ForegroundColor = pervious;
        }

        //  Func<>委托的目标
        static int Add(int x, int y)
        {
            return x + y;
        }

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
