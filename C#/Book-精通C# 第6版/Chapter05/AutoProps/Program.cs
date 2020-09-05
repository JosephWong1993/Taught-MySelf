using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            //创建一个汽车
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            Console.WriteLine("Your car is named {0}? That's odd...", c.PetName);
            c.DisplayStats();
            Console.WriteLine();

            //把汽车放入车库
            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number of Cars in garage:{0}", g.NumberOfCars);
            Console.ReadLine();
        }
    }
}
