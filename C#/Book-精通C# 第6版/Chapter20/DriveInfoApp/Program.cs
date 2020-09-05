using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with DriveInfo *****\n");

            //  得到所有驱动器的信息
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            //  输出驱动器统计信息
            foreach (DriveInfo d in myDrives)
            {
                Console.WriteLine("Name: {0}", d.Name);
                Console.WriteLine("Type: {0}", d.DriveType);

                //  检查驱动器是否已经准备好
                if (d.IsReady)
                {
                    Console.WriteLine("Free space: {0}", d.TotalFreeSpace);
                    Console.WriteLine("Format: {0}", d.DriveFormat);
                    Console.WriteLine("Label: {0}", d.VolumeLabel);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
