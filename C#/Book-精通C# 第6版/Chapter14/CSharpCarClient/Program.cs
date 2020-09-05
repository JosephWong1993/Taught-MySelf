using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# CarLibrary Client App *****");
            //  创建SportsCar对象
            SportsCar viper = new SportsCar("Viper", 240, 40);
            viper.TurboBoost();

            //  创建MiniVan对象
            MiniVan mv = new MiniVan();
            mv.TurboBoost();

            Console.WriteLine("Done.Press any key to terminate");
            Console.ReadLine();
        }
    }
}
