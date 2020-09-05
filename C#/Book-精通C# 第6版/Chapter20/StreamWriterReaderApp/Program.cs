using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with StreamWriter / StreamReader *****\n");

            //  得到一个StreamWriter对象并写入字符串数据
            //using (StreamWriter writer = File.CreateText(@"reminders.txt"))
            using(StreamWriter writer=new StreamWriter("reminders.txt"))
            {
                writer.WriteLine("Don't forget Mother's Day this year...");
                writer.WriteLine("Don't forget Father's Day this yead...");
                writer.WriteLine("Don't forget these numbers:");
                for (int i = 0; i < 10; i++)
                {
                    writer.Write(i + " ");
                }

                //  插入一个新行
                writer.Write(writer.NewLine);
            }

            Console.WriteLine("Created file and wrote some thoughts...");

            //  现在开始从文件读取数据
            Console.WriteLine("Here are your thoughgts:\n");
            //using (StreamReader sr = File.OpenText(@"reminders.txt"))
            using (StreamReader sr = new StreamReader("reminders.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
            Console.ReadLine();
        }
    }
}
