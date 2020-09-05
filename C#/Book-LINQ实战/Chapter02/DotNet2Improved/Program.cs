using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Common;

namespace DotNet2Improved
{
    static class LanguageFeature
    {
        class ProcessData
        {
            public int Id { get; set; }

            public long Memory { get; set; }

            public string Name { get; set; }
        }

        static void DisplayProcesses()
        {
            List<ProcessData> processes = new List<ProcessData>();
            foreach (Process process in Process.GetProcesses())
            {
                ProcessData data = new ProcessData();
                data.Id = process.Id;
                data.Name = process.ProcessName;
                data.Memory = process.WorkingSet64;
                processes.Add(data);
            }

            ObjectDumper.Write(processes);
        }

        static void Main(string[] args)
        {
            DisplayProcesses();

            Console.ReadKey();
        }
    }
}
