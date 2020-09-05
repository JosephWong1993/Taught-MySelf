using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AttributedCarLibrary;

namespace VehicleDescriptionAttributeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Value of VehicleDescriptionAttribute *****\n");
            ReflectOnAttributesUsingEarlyBinding();
            Console.ReadLine();
        }

        private static void ReflectOnAttributesUsingEarlyBinding()
        {
            //  得到一个表现Winnebago的类型
            Type t = typeof(Winnebago);

            //  得到Winnebago的所有特性
            object[] customAtts = t.GetCustomAttributes(false);

            //  输出描述
            foreach (VehicleDescriptionAttribute v in customAtts)
            {
                Console.WriteLine("-> {0}\n", v.Description);
            }
        }
    }
}
