using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloLinqWithGroupingAndSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };

            var groups =    //  按长度将单词分组 
                from word in words
                orderby word ascending
                group word by word.Length into lengthGroups
                orderby lengthGroups.Key descending
                select new { Length = lengthGroups.Key, Words = lengthGroups };

            foreach (var group in groups)   //  依次打印每组单词
            {
                Console.WriteLine("Words of length "+group.Length);
                foreach (string word in group.Words)
                {
                    Console.WriteLine("   "+word);
                }
            }

            Console.ReadLine();
        }
    }
}
