using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PublicDelegateProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Agh! No Encapsulation! *****\n");

            //  创建一个Car
            Car myCar = new Car();
            //  我们可以直接访问委托
            myCar.listOfHandlers = new Car.CarEngineHandler(CarWhenExploded);
            myCar.Accelerate(10);

            //  现在可以赋值一个全新的对象
            myCar.listOfHandlers = new Car.CarEngineHandler(CarHereToo);
            myCar.Accelerate(10);

            //  调用者还可以直接调用委托
            myCar.listOfHandlers.Invoke("hee,hee,hee...");

            Console.ReadLine();
        }

        private static void CarHereToo(string msg)
        {
            Console.WriteLine(msg);
        }

        private static void CarWhenExploded(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
