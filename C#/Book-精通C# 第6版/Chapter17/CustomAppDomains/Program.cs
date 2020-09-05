using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CustomAppDomains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom AppDomains *****\n");

            //  显示默认应用程序域中加载的所有程序集
            AppDomain defaultAD = AppDomain.CurrentDomain;
            defaultAD.ProcessExit += (o, s) =>
            {
                Console.WriteLine("Default AD unloaded!");
            };

            ListAllAssembliesInAppDomain(defaultAD);

            //  创建一个新的应用程序域
            MakeNewAppDomain();

            Console.ReadLine();
        }

        private static void MakeNewAppDomain()
        {
            //  在当前进程中新建一个AppDomain,并列出他所加载的程序集
            AppDomain newAD = AppDomain.CreateDomain("SecondAppDomain");

            newAD.DomainUnload += (o, s) =>
            {
                Console.WriteLine("The second AppDomain has been unloaded!");
            };

            try
            {
                //  现在加载CarLibrary.dll到这个新域中
                newAD.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //  列出所有的程序集
            ListAllAssembliesInAppDomain(newAD);

            //  现在卸载这个应用程序域
            AppDomain.Unload(newAD);
        }

        static void ListAllAssembliesInAppDomain(AppDomain ad)
        {
            //  现在获取应用程序域中加载的所有程序集
            var loadedAssemblies = from a in ad.GetAssemblies()
                                   orderby a.GetName().Name
                                   select a;

            Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n",
                ad.FriendlyName);
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine("-> Name: {0}", a.GetName().Name);
                Console.WriteLine("-> Version: {0}", a.GetName().Version);
            }
        }
    }
}
