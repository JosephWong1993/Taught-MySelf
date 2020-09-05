using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringWithQperators();
            Console.WriteLine();

            QueryStringWithEnumerableAndLambdas();
            Console.WriteLine();

            QueryStringWithAnonymousMethids();
            Console.WriteLine();

            VeryComplexQueryExpression.QueryStringsWithRawDelegates();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void QueryStringWithQperators()
        {
            Console.WriteLine("***** Using Query Operations *****");

            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            var subset = from game in currentVideoGames
                         where game.Contains(' ')
                         orderby game
                         select game;

            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
        }

        static void QueryStringWithEnumerableAndLambdas()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            //用通过Enumerable类型赋予Array的扩展方法建立查询表达式
            var gameWithSpaces = currentVideoGames.Where(game => game.Contains(" "));
            var orderedGames = gameWithSpaces.OrderBy(game => game);
            var subset = orderedGames.Select(game => game);

            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
        }

        static void QueryStringWithAnonymousMethids()
        {
            Console.WriteLine("***** Using Anonymous Methods *****");

            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            //  使用匿名方法建立所需的Func<>委托
            Func<string, bool> searchFilter = delegate(string game)
            {
                return game.Contains(" ");
            };
            Func<string, string> itemToProcess = delegate(string s)
            {
                return s;
            };

            //  把委托传递给Enumerable的方法
            var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
        }
    }
}
