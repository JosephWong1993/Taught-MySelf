using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqOverCustomObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over Generic Collections *****");

            //  生成一系列Car对象
            List<Car> myCars = new List<Car>()
            {
                new Car{PetName="Henry",Color="Silver",Speed=100,Make="BMW"},
                new Car{PetName="Daisy",Color="Tan",Speed=90,Make="BMW"},
                new Car{PetName="Mary",Color="Black",Speed=55,Make="VW"},
                new Car{PetName="Clunker",Color="Rust",Speed=5,Make="Yugo"},
                new Car{PetName="Melvin",Color="White",Speed=43,Make="Ford"}
            };

            GetFastCars(myCars);

            Console.ReadLine();
        }

        static void GetFastCars(List<Car> myCars)
        {
            //  找到List<>中所有Speed大于55的Car对象
            var fastCars = from c in myCars
                           where c.Speed > 55
                           select c;

            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }

        static void GetFastBMWs(List<Car> myCars)
        {
            //  找到最快的宝马车
            var fastCars = from c in myCars
                           where c.Speed > 90 && c.Make == "BMW"
                           select c;
            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }
    }
}
