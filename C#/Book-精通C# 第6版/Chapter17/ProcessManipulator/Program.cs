using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProcessManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Processes *****\n");
            ListAllRunningProcesses();

            GetSpecificProcess();

            //  提示用户输入PID,并输出一组活动的线程
            Console.WriteLine("***** Enter PID of process to investigate *****");
            Console.Write("PID: ");
            string pID = Console.ReadLine();
            int theProcID = int.Parse(pID);
            EnumThreadsForPid(theProcID);
            EnumModsForPid(theProcID);

            StartAndKillProcess();
            Console.ReadLine();
        }

        static void ListAllRunningProcesses()
        {
            //  得到本机的所有进程,按PID顺序
            var runningProcs = from proc in Process.GetProcesses(".")
                               orderby proc.Id
                               select proc;

            //  输出每个进程的PID和名称
            foreach (var p in runningProcs)
            {
                string info = string.Format("-> PID:{0}\tName: {1}",
                    p.Id, p.ProcessName);
                Console.WriteLine(info);
            }
            Console.WriteLine("*************************************\n");
        }

        //  如果PID为987的进程不存在,将会引发运行时错误
        static void GetSpecificProcess()
        {
            Process thProc = null;
            try
            {
                thProc = Process.GetProcessById(987);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void EnumThreadsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            //  列出指定进程中每个线程的统计数字
            Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);
            ProcessThreadCollection theThreads = theProc.Threads;
            foreach (ProcessThread pt in theThreads)
            {
                string info = string.Format("-> Thread ID: {0}\tStart Time: {1}\tPriority: {2}",
                    pt.Id,
                    pt.StartTime.ToShortDateString(),
                    pt.PriorityLevel);
                Console.WriteLine(info);
            }
            Console.WriteLine("*************************************\n");
        }

        static void EnumModsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine("Here are the loaded modules for: {0}",
                theProc.ProcessName);
            ProcessModuleCollection theMods = theProc.Modules;
            foreach (ProcessModule pm in theMods)
            {
                string info = string.Format("-> Mod Name: {0}",
                    pm.ModuleName);
                Console.WriteLine(info);
            }
            Console.WriteLine("*************************************\n");
        }

        static void StartAndKillProcess()
        {
            Process ieProc = null;

            //  启动ID,进入Facebook
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe", "www.facebook.com");
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                ieProc = Process.Start(startInfo);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("--> Hit enter to Kill {0}...",
                ieProc.ProcessName);
            Console.ReadLine();

            //  结束iexplorer.exe
            try
            {
                ieProc.Kill();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
