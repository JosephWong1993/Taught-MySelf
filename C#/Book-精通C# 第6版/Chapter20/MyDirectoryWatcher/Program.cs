using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyDirectoryWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Amazing File Watcher App *****\n");

            //  确定指向要观察的目录的路径
            FileSystemWatcher watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = @"D:\MyFolder";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            //  设置需要留意的事情
            watcher.NotifyFilter = NotifyFilters.LastAccess
                | NotifyFilters.LastWrite
                | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            //  只观察文本文件
            watcher.Filter = "*.txt";

            //  增加时间处理程序
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            //  开始观察目录
            watcher.EnableRaisingEvents = true;

            //  等待用户退出程序
            Console.WriteLine(@"Press 'q' to quit app.");

            while (Console.Read() != 'q') ;
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            //  指定当文件改变,创建或者删除的时候需要做的事情
            Console.WriteLine("File: {0} {1}!", e.FullPath, e.ChangeType);
        }
        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            //  指定当文件重命名的时候需要做的事情
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
}
