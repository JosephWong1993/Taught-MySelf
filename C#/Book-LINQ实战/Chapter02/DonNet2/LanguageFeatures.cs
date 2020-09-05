using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DonNet2
{
    static class LanguageFeatures
    {
        static void DisplayProcesses()
        {
            List<String> processes = new List<string>();    //  准备字符串列表
            foreach (Process process in Process.GetProcesses()) //  生成进程列表
            {
                processes.Add(process.ProcessName);
            }
            ObjectDumper.Write(processes);   //  输出到控制台
        }
         static void Main(string[] args)
        {
            DisplayProcesses();

            Console.ReadKey();
        }
    }
}
