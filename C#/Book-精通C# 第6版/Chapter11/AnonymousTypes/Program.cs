using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Annoymous Types *****\n");

            //  构建一个匿名对象表示一辆汽车
            var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            //使用反射输出编辑器生成的内容
            ReflectOverAnonymousType(myCar);

            //  显示颜色并输出
            Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Make);

            //  调用辅助方法通过实参创建匿名类型
            BuildAnonType("BMW", "Black", 90);
            Console.WriteLine();

            EqualityTest();

            Console.ReadLine();
        }

        static void BuildAnonType(string make, string color, int curSp)
        {
            //  使用传入参数构建匿名类型
            var car = new { Make = make, Color = color, Speed = curSp };

            //  注意,现在可以使用该类型获取属性数据
            Console.WriteLine("You have a {0} {1} going {2} MPH",
                car.Color, car.Make, car.Speed);

            //  匿名类型包含对System.Object中每个虚方法的自定义实现
            Console.WriteLine("ToString() == {0}", car.ToString());
        }

        static void ReflectOverAnonymousType(object obj)
        {
            Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}",
                obj.GetType().Name,
                obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode == {0}", obj.GetHashCode());
            Console.WriteLine();
        }


        static void EqualityTest()
        {
            //  构建两个匿名类,拥有相同的名称/值对
            var firstCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            var seconfCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            //  调用Equals()的结果是什么
            if (firstCar.Equals(seconfCar))
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");

            //  调用==操作符进行比较的结果是什么?
            if (firstCar == seconfCar)
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");

            if (firstCar.GetType().Name == seconfCar.GetType().Name)
                Console.WriteLine("We are both the same type!");
            else
                Console.WriteLine("We are different types!");

            //  显示两个匿名类的细节
            Console.WriteLine();
            ReflectOverAnonymousType(firstCar);
            ReflectOverAnonymousType(seconfCar);
        }
    }
}
