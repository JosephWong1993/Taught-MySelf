using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldSchoolHello
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "wonderful", "linq", "beautiful", "world" };

            foreach (string word in words)
            {
                if (word.Length <= 5)
                    Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
