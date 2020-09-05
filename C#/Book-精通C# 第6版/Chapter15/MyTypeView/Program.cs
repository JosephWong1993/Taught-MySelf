using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace MyTypeView
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyTypeViewer *****");
            string typeName = string.Empty;

            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.WriteLine("or enter Q to quit:");

                //  得到类型的名称
                typeName = Console.ReadLine();

                //  询问用户是否想退出
                if (typeName.ToUpper() == "Q")
                    break;

                //  测试显示类型
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine();
                    ListVariousStats(t);
                    ListFields(t);
                    ListProps(t);
                    ListMethods(t);
                    ListInterfaces(t);
                }
                catch
                {
                    Console.WriteLine("Sorry,can't find type");
                }
            } while (true);
        }

        //  显示类型的方法名称
        static void ListMethods(Type t)
        {
            Console.WriteLine("***** Methods *****");
            var methods = from n in t.GetMethods() select t;
            foreach (var m in methods)
                Console.WriteLine("-> {0}", m);
            Console.WriteLine();
        }

        //  显示类型的字段名
        static void ListFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            var fieldNames = from f in t.GetFields() select f.Name;
            foreach (var name in fieldNames)
                Console.WriteLine("->{0}", name);
            Console.WriteLine();
        }

        //  显示类型的属性名称
        static void ListProps(Type t)
        {
            Console.WriteLine("***** Properties *****");
            var propNames = from p in t.GetProperties() select p.Name;
            foreach (var name in propNames)
                Console.WriteLine("->{0}", name);
            Console.WriteLine();
        }

        //  显示实现的接口
        static void ListInterfaces(Type t)
        {
            Console.WriteLine("***** Interfaces *****");
            var ifaces = from i in t.GetInterfaces() select i;
            foreach (var i in ifaces)
                Console.WriteLine("->{0}", i.Name);
            Console.WriteLine();
        }

        //  为了更好的检测
        static void ListVariousStats(Type t)
        {
            Console.WriteLine("***** Various Statistics *****");
            Console.WriteLine("Base class is: {0}", t.BaseType);
            Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
            Console.WriteLine("Is type sealed? {0}", t.IsSealed);
            Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Is type a class type? {0}", t.IsClass);
            Console.WriteLine();
        }
    }
}
