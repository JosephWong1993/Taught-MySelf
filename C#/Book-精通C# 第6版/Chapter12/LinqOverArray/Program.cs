using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with LINQ to Objects *****");
            QueryOverStrings();
            Console.WriteLine();

            QueryOverInts();
            Console.ReadLine();
        }

        static void QueryOverStrings()
        {
            //  假定我们有一个字符串数组
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            //  构建一个查询表达式,来代表数组中有一个空格的项
            IEnumerable<string> subset = from game in currentVideoGames
                                         where game.Contains(" ")
                                         orderby game
                                         select game;

            //  输出结果
            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
            ReflectOverQueryResults(subset);
        }

        static void QueryOverStringLongHand()
        {
            //  假定我们有一个字符串数组
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            string[] gamesWithSpaces = new string[5];
            for (int i = 0; i < currentVideoGames.Length; i++)
            {
                if (currentVideoGames[i].Contains(" "))
                {
                    gamesWithSpaces[i] = currentVideoGames[i];
                }
            }

            //  排序
            Array.Sort(gamesWithSpaces);

            //  打印结果
            foreach (string s in gamesWithSpaces)
            {
                if (s != null)
                {
                    Console.WriteLine("Item: {0}", s);
                }
            }
            Console.WriteLine();
        }

        static void ReflectOverQueryResults(object resultSet)
        {
            Console.WriteLine("***** Info about your query *****");
            Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
        }

        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            //  获取小于10的数
            var subset = from i in numbers where i < 10 select i;

            //  LINQ语句在这里运算
            foreach (var i in subset)
            {
                Console.WriteLine("{0} < 10", i);
            }
            Console.WriteLine();

            //  修改数组中的一些数据
            numbers[0] = 4;

            //  再一次运算
            foreach (var j in subset)
            {
                Console.WriteLine("{0} < 10", j);
            }
            Console.WriteLine();

            ReflectOverQueryResults(subset);
        }

        static void ImmediateExcution()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            //  立即获取数据为int[]
            int[] subsetAsIntArray = (from i in numbers where i < 10 select i).ToArray<int>();

            //  立即获取数据为List<int>
            List<int> subsetAsListOfInts = (from i in numbers where i < 10 select i).ToList<int>();
        }
    }
}
