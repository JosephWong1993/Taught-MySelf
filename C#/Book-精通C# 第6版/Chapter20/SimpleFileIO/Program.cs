using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple I/O with the File Type *****\n");
            string[] myTasks =
            {
                "Fix bathroom sink","Call Dave",
                "Call Mon and Dad","Play Xbox 360"
            };

            //  向C盘的文件写入所有数据
            File.WriteAllLines(@"D:\tasks.txt", myTasks);

            //  重新读取然后输出
            foreach (string task in File.ReadAllLines(@"D:\tasks.txt"))
            {
                Console.WriteLine("TODO: {0}", task);
            }
            Console.ReadLine();
        }
    }
}
