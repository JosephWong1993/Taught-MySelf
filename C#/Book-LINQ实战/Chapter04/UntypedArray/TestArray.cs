using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UntypedArray
{
    static class TestArray
    {
        static void Main()
        {
            Object[] array = { "String", 12, true, 'a' };
            var types = array
                .Select(item => item.GetType().Name)
                .OrderBy(type => type);

            ObjectDumper.Write(types);

            Console.ReadKey();
        }
    }
}
