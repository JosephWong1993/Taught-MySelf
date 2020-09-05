using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Directory(Info) *****\n");
            ShowWindowsDirectoryInfo();
            DisplayImageFiles();
            ModifyAppDirectory();
            FunWithDirectoryType();
            Console.ReadLine();
        }

        static void ShowWindowsDirectoryInfo()
        {
            //  转储目录信息
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            Console.WriteLine("***** Directory Info *****");
            Console.WriteLine("FullName:{0}", dir.FullName);
            Console.WriteLine("Name:{0}", dir.Name);
            Console.WriteLine("Parent:{0}", dir.Parent);
            Console.WriteLine("Creation:{0}", dir.CreationTime);
            Console.WriteLine("Attributes:{0}", dir.Attributes);
            Console.WriteLine("Root:{0}", dir.Root);
            Console.WriteLine("********************\n");
        }

        static void DisplayImageFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
            //  获取所有*.jpg文件
            FileInfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);
            //  我们找到多少文件
            Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);
            //  输出每个文件的信息
            foreach (FileInfo f in imageFiles)
            {
                Console.WriteLine("******************");
                Console.WriteLine("File name: {0}", f.Name);
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Attribute: {0}", f.Attributes);
                Console.WriteLine("******************\n");
            }
        }

        static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(@".");

            //  在初始目录下创建\MyFolder
            dir.CreateSubdirectory("MyFolder");
            //  捕获返回的DirectoryInfo类型
            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"MyFolder2\Data");
            //  在..\MyFolder2\Data上输出路径
            Console.WriteLine("New Folder is: {0}", myDataFolder);
        }

        static void FunWithDirectoryType()
        {
            //  列出当前电脑的所有驱动器
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Here are your drives:");
            foreach (string s in drives)
            {
                Console.WriteLine("--> {0}", s);
            }

            //  删除前面建立的目录
            Console.WriteLine("Press Enter to delete directories");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"MyFolder");

                //  第二个参数指定你是否希望删除子目录
                Directory.Delete(@"MyFolder2", true);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
