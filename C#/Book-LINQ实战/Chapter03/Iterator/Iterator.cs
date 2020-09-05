using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Iterator
    {
        static IEnumerable<int> OneTwoThree()
        {
            Console.WriteLine("Returning 1");
            yield return 1;
            Console.WriteLine("Returning 2");
            yield return 2;
            Console.WriteLine("Returning 2");
            yield return 3;
        }

        static void Main(string[] args)
        {
            foreach (var number in OneTwoThree())
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
