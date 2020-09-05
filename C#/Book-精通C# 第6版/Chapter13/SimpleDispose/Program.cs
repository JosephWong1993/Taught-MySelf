using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Dispose *****");
            //  当退出using作用域时,自动调用Dispose()
            using (MyResourceWrapper rw = new MyResourceWrapper(),
                rw2 = new MyResourceWrapper())
            {
                //  使用rw和rw2对象
            }

            Console.WriteLine();

            DisposeFileStream();

            Console.ReadLine();
        }

        //  假设我们已经导入了Stream.IO命名空间
        static void DisposeFileStream()
        {
            FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);

            //  确实有点混淆,这两个方法调用完成相同的事情
            fs.Close();
            fs.Dispose();
        }
    }
}
