using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");

            //创建一个Car对象并设置最大速度
            Car myCar = new Car(80);

            //设置当前速度并输出
            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);
            Console.WriteLine();

            //  创建MiniVan对象
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My Van is going {0} MPH", myVan.Speed);

            //  错误!不能访问私有成员
            //myVan.currSpeed = 50;
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
