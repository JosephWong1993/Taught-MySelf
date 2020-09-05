using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");

            //这刚刚好
            TimeUtilClass.PrintData();
            TimeUtilClass.PrintTime();

            Console.ReadLine();
        }
    }
}
