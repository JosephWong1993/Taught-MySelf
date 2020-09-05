using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "wonderfule", "linq", "beautiful", "world" };

            var shortWords =
                from word in words
                where word.Length <= 5
                select word;

            foreach (string word in shortWords)
                Console.WriteLine(word);

            Console.ReadLine();
        }
    }
}
