using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqUsingEnumerable
{
    class VeryComplexQueryExpression
    {
        public static void QueryStringsWithRawDelegates()
        {
            Console.WriteLine("***** Using Raw Delegates *****");

            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            //  建立所需的Func<>委托
            Func<string, bool> searchFilter = new Func<string, bool>(Filter);

            Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);

            //  把委托传递给Enumerable的方法
            var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
        }

        private static bool Filter(string game)
        {
            return game.Contains(" ");
        }

        private static string ProcessItem(string game)
        {
            return game;
        }
    }
}
