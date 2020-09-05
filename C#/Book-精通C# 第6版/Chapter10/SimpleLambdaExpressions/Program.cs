using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");

            TraditionalDelegateSyntax();
            
            AnonymousMethodSyntax();
            Console.WriteLine();
            LambdaExpressionSyntax();

            Console.ReadLine();
        }

        static void TraditionalDelegateSyntax()
        {
            //  创建整数列表
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //  使用传统委托语法调用FindAll()
            Predicate<int> callback = new Predicate<int>(IsEvenNumber);
            List<int> evenNumbers = list.FindAll(callback);

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        //  Prdicate<>委托的目标
        private static bool IsEvenNumber(int i)
        {
            //  这是一个偶数吗
            return (i % 2) == 0;
        }

        static void AnonymousMethodSyntax()
        {
            //  创建整数列表
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //  现在使用匿名方法
            List<int> evenNumbers = list.FindAll(
                delegate(int i)
                {
                    return (i % 2) == 0;
                }
            );

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        static void LambdaExpressionSyntax()
        {
            //  创建整数列表
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //  现在使用Lambda表达式
            List<int> evenNumbers = list.FindAll((int i) =>
            {
                Console.WriteLine("value of i is currently:{0}", i);
                bool isEven = ((i % 2) == 0);
                return isEven;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

       
    }
}
