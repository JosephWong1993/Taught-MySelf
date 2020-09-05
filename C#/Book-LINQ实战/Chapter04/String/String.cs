using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String
{
    class String
    {
        static void Main(string[] args)
        {
            var count =
                "Non-letter characters in this string: 8"
                .Where<char>(c => !Char.IsLetter(c))
                .Count<char>();
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
