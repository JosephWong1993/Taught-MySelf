using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Extending Interface Compatible Types *****");

            //  SystemArray 实现 IEnumerable
            string[] data = { "Wow", "this", "is", "short", "of", "annoying",
                                "but", "in", "a", "werid", "way", "fun!" };
            data.PrintDataAndBeep();

            Console.WriteLine();

            //  List<T> 实现 IEnumerable
            List<int> myInts = new List<int>() { 10, 15, 20 };
            myInts.PrintDataAndBeep();

            Console.ReadLine();
        }
    }
}
