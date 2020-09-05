using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UsingVar
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
            var processes = new List<ProcessData>();
            foreach (var process in Process.GetProcesses())
            {
                var data = new ProcessData();
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
