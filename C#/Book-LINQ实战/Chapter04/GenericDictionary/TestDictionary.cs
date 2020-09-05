using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDictionary
{
    class TestDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> frenchNumbers;
            frenchNumbers = new Dictionary<int, string>();
            frenchNumbers.Add(0, "Zero");
            frenchNumbers.Add(1, "un");
            frenchNumbers.Add(2, "deux");
            frenchNumbers.Add(3, "trois");
            frenchNumbers.Add(4, "quatre");

            var evenFrenchNumbers =
                from entry in frenchNumbers
                where (entry.Key % 2) == 0
                select entry.Value;
            ObjectDumper.Write(evenFrenchNumbers);

            Console.ReadKey();
        }
    }
}
