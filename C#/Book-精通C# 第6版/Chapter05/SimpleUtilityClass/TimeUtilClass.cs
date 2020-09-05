using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleUtilityClass
{
    static class TimeUtilClass
    {
        public static void PrintTime()
        { Console.WriteLine(DateTime.Now.ToShortTimeString()); }

        public static void PrintData()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }
    }
}
