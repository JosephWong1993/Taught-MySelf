using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeferredQueryExecution
{
    class DeferredQueryException
    {
        static double Square(double n)
        {
            Console.WriteLine("Computing Square （" + n + ")...");
            return Math.Pow(n, 2);
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            var query = from n in numbers
                        select Square(n);

            foreach (var n in query)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
