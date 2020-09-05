using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the Yield Keyword *****\n");
            Garage carlot = new Garage();

            //使用GetEnumerator()获取项
            foreach (Car c in carlot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.WriteLine();

            foreach (Car c in carlot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.ReadLine();
        }
    }
}
