using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with IEnumerable /Ienumerator *****\n");
            Garage carLot = new Garage();

            //移交集合中的每个Car对象吗?
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }
            Console.WriteLine();

            IEnumerator i = carLot.GetEnumerator();
            i.Reset();
            i.MoveNext();
            Car MyCar = (Car)i.Current;
            Console.WriteLine("{0} is going {1} MPH", MyCar.PetName, MyCar.CurrentSpeed);

            Console.ReadLine();
        }
    }
}
