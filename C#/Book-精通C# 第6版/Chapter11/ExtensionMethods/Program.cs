using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Extension Methods *****");

            //  本整形表示一个新的身份标识
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            //  下面是DataSet
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();

            //  下面是SoundPlayer
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssembly();

            //  使用整形的新功能
            Console.WriteLine("Value of myInt: {0}", myInt);
            Console.WriteLine("Reversed digits of myInt: {0}", myInt.ReverseDigits());

            Console.ReadLine();
        }
    }
}
