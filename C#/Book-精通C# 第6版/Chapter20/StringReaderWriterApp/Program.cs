using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringReaderWriterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with StringWriter / StringReader *****\n");

            //  创建一个StringWriter并把字符数据写入内存
            using (StringWriter strWriter = new StringWriter())
            {
                strWriter.WriteLine("Don't forget Mother's Day this year...");
                //  获取内容副本(存储在字符串中)并向控制台输出
                Console.WriteLine("Contents of StringWriter:\n{0}", strWriter);

                //  得到内部的StringBuilder
                StringBuilder sb = strWriter.GetStringBuilder();
                sb.Insert(0, "Hey!! ");
                Console.WriteLine("-> {0}", sb.ToString());
                sb.Remove(0, "Hey!! ".Length);
                Console.WriteLine("-> {0}", sb.ToString());

                //  从StringWriter读取数据
                using (StringReader strReader = new StringReader(strWriter.ToString()))
                {
                    string input = null;
                    while ((input = strReader.ReadLine()) != null)
                    {
                        Console.WriteLine(input);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
