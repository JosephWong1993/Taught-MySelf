using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ExternalAssemblyReflector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** External Assembly Viewer *****");
            string asmName = string.Empty;
            Assembly asm = null;
            do
            {
                Console.WriteLine("\n Enter an assembly to evaluate");
                Console.WriteLine("or enter Q to quit:");

                //  得到这个程序集名称
                asmName = Console.ReadLine();

                //  用户是否想退出
                if (asmName.ToUpper() == "Q")
                    break;

                //  尝试加载程序集
                try
                {
                    asm = Assembly.LoadFrom(asmName);
                    DisplayTypesInAsm(asm);
                }
                catch
                {
                    Console.WriteLine("Sorry,can't find assembly");
                }
            } while (true);
        }

        static void DisplayTypesInAsm(Assembly asm)
        {
            Console.WriteLine("\n***** Types in Assembly *****");
            Console.WriteLine("-> {0}", asm.FullName);
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
                Console.WriteLine("Type: {0}", t);
            Console.WriteLine();
        }
    }
}
