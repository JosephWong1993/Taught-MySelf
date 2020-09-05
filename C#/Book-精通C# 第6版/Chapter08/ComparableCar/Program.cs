using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Storing *****\n");

            //  建立一个Car对象数组
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);

            //  显示当前数组
            Console.WriteLine("Here is the unordered set of cars:");
            foreach (Car c in myAutos)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            }

            //  现在,使用IComparable为它们排序
            Array.Sort(myAutos);
            Console.WriteLine();

            //显示排序后的数组
            Console.WriteLine("Here is the ordered set of cars:");
            foreach (Car c in myAutos)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            }

            //  按照昵称进行排序
            Array.Sort(myAutos,Car.SortByPetName);

            Console.WriteLine("Ordering by pet name:");
            foreach (Car c in myAutos)
            {
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            }

            Console.ReadLine();
        }
    }
}
