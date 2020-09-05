using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CompleteCode
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
            var processes = new List<ProcessData>();    //  隐式类型局部变量
            foreach (var process in Process.GetProcesses())
            {
                if (match(process))
                {
                    processes.Add(new ProcessData   //  对象初始化器
                    {
                        Id = process.Id,
                        Name = process.ProcessName,
                        Memory = process.WorkingSet64
                    });
                }
            }

            Console.WriteLine("Total memory: {0} MB", processes.TotalMemory() / 1024 / 1024);   //  扩展方法

            //ObjectDumper.Write(processes.OrderByDescending(process => process.Memory));
            long top2Memory = processes
                .OrderByDescending<ProcessData, long>((ProcessData process) => process.Memory)
                .Take(2)
                .Sum(process => process.Memory) / 1024 / 1024;

            Console.WriteLine("Memory consumed by the two most hungry processes: {0} MB", top2Memory);

            var results = new
            {
                TotalMemory = processes.TotalMemory() / 1024 / 1024,
                Top2Memory = top2Memory,
                Processes = processes,
            };
            ObjectDumper.Write(results, 1);

            ObjectDumper.Write(processes);
        }

        static void Main(string[] args)
        {
            DisplayProcesses(process => process.WorkingSet64 >= 20 * 1024 * 1024);

            Console.ReadKey();
        }

        static long TotalMemory(this IEnumerable<ProcessData> processes)
        {
            long result = 0;
            foreach (var process in processes)
            {
                result += process.Memory;
            }
            return result;
        }
    }
}
