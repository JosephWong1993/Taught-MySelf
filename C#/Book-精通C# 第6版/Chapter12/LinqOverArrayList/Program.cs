using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqOverArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over ArrayList *****");

            //  这是个非泛型的车集合
            ArrayList myCars = new ArrayList()
            {
                new Car{PetName="Henry",Color="Silver",Speed=100,Make="BMW"},
                new Car{PetName="Daisy",Color="Tan",Speed=90,Make="BMW"},
                new Car{PetName="Mary",Color="Black",Speed=55,Make="VW"},
                new Car{PetName="Clunker",Color="Rust",Speed=5,Make="Yugo"},
                new Car{PetName="Melvin",Color="White",Speed=43,Make="Ford"}
            };

            //  把ArrayList转换成一个兼容与IEnumerable<T>的类型
            var myCarsEnum = myCars.OfType<Car>();

            //  建立兼容类型的查询表达式
            var fastCars = from c in myCarsEnum
                           where c.Speed > 55
                           select c;

            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
            Console.WriteLine();

            OfTypeAsFilter();

            Console.ReadLine();
        }

        static void OfTypeAsFilter()
        {
            //  从ArrayList中提取整数
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
            var myInts = myStuff.OfType<Int32>();

            //  输出10,400和8
            foreach (int i in myInts)
            {
                Console.WriteLine("Int value: {0}", i);
            }
        }
    }
}
