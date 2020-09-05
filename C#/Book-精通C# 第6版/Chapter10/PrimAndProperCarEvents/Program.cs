using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimAndProperCarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Events *****\n");
            Car c1 = new Car("SlugBug", 100, 10);

            //  注册事件处理程序
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;
            c1.Exploded += CarExploded;

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Acclerate(20);

            c1.Exploded -= CarExploded;

            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Acclerate(20);

            Console.ReadLine();
        }

        static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.msg);
        }

        private static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            Car c = (Car)sender;
            Console.WriteLine("=> Critical Message from {0}: {1}", c.PetName, e.msg);
        }

        static void CarExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.msg);
        }
    }
}
