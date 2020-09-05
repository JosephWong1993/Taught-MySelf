using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectContextApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Context *****\n");

            //  对象将显示创建时的上下文信息
            SportsCar sport = new SportsCar();
            Console.WriteLine();

            SportsCar sport2 = new SportsCar();
            Console.WriteLine();

            SportsCarTS synchroSport = new SportsCarTS();
            Console.ReadLine();
        }
    }
}
