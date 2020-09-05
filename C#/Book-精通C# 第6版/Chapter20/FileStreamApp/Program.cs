using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamApp
{
    class Program
    {
        //  不要忘记导入System.Text和System.IO命名空间
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with FileStreams *****\n");
            //  获取一个FileStream对象
            using (FileStream fStream = File.Open(@"D:\MyMessage.dat", FileMode.Create))
            {
                //  把字符串编码成字节数组
                string msg = "Hello!";
                byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);

                //  把byte[]写入文件
                fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);

                //  重置流内部的位置
                fStream.Position = 0;

                //  从文件读取字节并显示在控制台
                Console.WriteLine("Your message as an array of byes:");
                byte[] bytesFromFile = new byte[msgAsByteArray.Length];
                for (int i = 0; i < msgAsByteArray.Length; i++)
                {
                    bytesFromFile[i] = (byte)fStream.ReadByte();
                    Console.WriteLine(bytesFromFile[i]);
                }

                //  显示解码后的字符串
                Console.Write("\nDecoded Message:");
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            }
            Console.ReadLine();
        }
    }
}
