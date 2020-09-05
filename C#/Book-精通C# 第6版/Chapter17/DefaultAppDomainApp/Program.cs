using System;
using System.Reflection;
using System.Linq;

namespace DefaultAppDomainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the default AppDomain *****\n");
            
            InitDAD();
            
            DisplayDADStats();

            ListAllAssembliesInAppDomain();

            Console.ReadLine();
        }

        private static void DisplayDADStats()
        {
            //  访问当前线程的应用程序域
            AppDomain defaultAD = AppDomain.CurrentDomain;

            //  打印该域中的不同状态
            Console.WriteLine("Name of this domain: {0}", defaultAD.FriendlyName);
            Console.WriteLine("ID of domain in this process: {0}", defaultAD.Id);
            Console.WriteLine("Is this the default domain?: {0}", defaultAD.IsDefaultAppDomain());
            Console.WriteLine("Base directory of this domain: {0}", defaultAD.BaseDirectory);
        }

        static void ListAllAssembliesInAppDomain()
        {
            //  访问当前线程的应用程序域
            AppDomain defaultAD = AppDomain.CurrentDomain;

            //  获取默认应用程序域中所有加载的程序集
            var loadedAssemblies = from a in defaultAD.GetAssemblies()
                                   orderby a.GetName().Name
                                   select a;
            Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n",
                defaultAD.FriendlyName);

            foreach (Assembly a in loadedAssemblies)
            {
                Console.WriteLine("-> Name: {0}", a.GetName().Name);
                Console.WriteLine("-> Version: {0}", a.GetName().Version);
            }
        }

        private static void InitDAD()
        {
            //   这段逻辑将在应用程序域创建后,打印加载到应用程序域的程序集名称
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.AssemblyLoad += (o, s) =>
            {
                Console.WriteLine("{0} has benn loaded", s.LoadedAssembly.GetName().Name);
            };

        }
    }
}
