using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExtensions
{
    static class AnnoyingExtensions
    {
        public static void PrintDataAndBeep(this System.Collections.IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.Write(item);
                Console.Beep();
            }
        }
    }
}
