using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ObjectInitializer
{
    static class LanguageFeature
    {
        class ProcessData
        {
            public int Id { get; set; }

            public long Memory { get; set; }

            public string Name { get; set; }
        }

        static void DisplayProcesses(Predicate<Process> match)
        {
            var processes = new List<ProcessData>();    //  创建与条件匹配的进程列表
            foreach (var process in Process.GetProcesses())
            {
                if (match(process))
                {
                    processes.Add(new ProcessData
                    {
                        Id = process.Id,
                        Name = process.ProcessName,
                        Memory = process.WorkingSet64
                    });
                }
            }

            var visualStudio = processes.Find(delegate (ProcessData process)
            {
                return process.Name == "devenv";
            });

            ObjectDumper.Write(processes);
        }

        static void Main(string[] args)
        {
            DisplayProcesses(process => process.WorkingSet64 >= 20 * 1024 * 1024);

            Console.ReadKey();
        }
    }
}
