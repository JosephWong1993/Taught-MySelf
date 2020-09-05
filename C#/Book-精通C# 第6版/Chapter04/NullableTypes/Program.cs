using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader();

            //从"数据库"获取int
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
            {
                Console.WriteLine("Value of 'i' is:{0}", i.Value);
            }
            else
            {
                Console.WriteLine("Value of 'i' is undefined");
            }

            //从"数据库"获取bool
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
            {
                Console.WriteLine("Value of 'b' is :{0}", b.Value);
            }
            else
            {
                Console.WriteLine("Value of 'b' is undefined");
            }
            Console.WriteLine();

            //从GetIntFromDatabase()返回的值为null时,将局部变量赋值为100
            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData:{0}", myData);

            Console.ReadLine();
        }

        static void LocalNullableVariables()
        {
            //  定义一些局部可空类型
            int? nullableInt = 10;
            double? nullableDouble = 3.14D;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];
        }
    }
}
