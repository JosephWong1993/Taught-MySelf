using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun woth System.GC *****");

            //  输出堆上估计的字节数量
            Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));

            //  MaxGeneration是由0开始的,因此未来显示的目的加上了1
            Console.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));

            //  在托管堆上创建一个新的Car对象.返回一个对这个对象的引用('refToMyCar')
            Car refToMyCar = new Car("Zippy", 50);

            //  用C#的点操作符(.)来调用使用了引用变量的对象的成员
            Console.WriteLine(refToMyCar.ToString());

            //  输出refToMyCar对象的代
            Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

            //  为测试目的创建对象数组
            object[] tonsOfObjects = new object[50000];
            for (int i = 0; i < 50000; i++)
            {
                tonsOfObjects[i] = new object();
            }

            //  仅回收第0代对象
            GC.Collect(0);
            GC.WaitForPendingFinalizers();

            //  输出refToMyCar对象的代
            Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

            //  看一下tonsOfObjects[9000]是否还活着
            if (tonsOfObjects[9000] != null)
            {
                Console.WriteLine("Generation of tansOfObjects[9000] is: {0}",
                    GC.GetGeneration(tonsOfObjects[9000]));
            }
            else
                Console.WriteLine("tonsOfObjects[9000] is no longer live.");

            //  输出一个代被清除的次数
            Console.WriteLine("Gen 0 has been swept {0} times",GC.CollectionCount(0));
            Console.WriteLine("Gen 1 has been swept {0} times", GC.CollectionCount(1));
            Console.WriteLine("Gen 2 has been swept {0} times", GC.CollectionCount(2));

            Console.ReadLine();
        }
    }
}
