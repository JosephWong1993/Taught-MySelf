using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Binary writers / Readers *****\n");

            //  为文件打开一个二进制编写器
            FileInfo f = new FileInfo("BinFile.dat");
            using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
            {
                //  输出BaseStream的类型(这里是System.IO.FileStream)
                Console.WriteLine("Base stream is: {0}", bw.BaseStream);

                //  在文件中存储一些数据
                double aDouble = 1234.67;
                int anInt = 34567;
                string aString = "A,B,C";

                //  写数据
                bw.Write(aDouble);
                bw.Write(anInt);
                bw.Write(aString);
            }
            Console.WriteLine("Done!");

            //  从流中读取二进制数据
            using (BinaryReader br = new BinaryReader(f.OpenRead()))
            {
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
            }
            Console.ReadLine();
        }
    }
}
