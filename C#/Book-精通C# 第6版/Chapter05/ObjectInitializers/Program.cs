using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            //  通过手动设置各个属性来创建Point
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            //  或通过自定义构造函数创建Point
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            //  或使用对象初始化语法来创建Point
            Point finalPoint = new Point(10, 16) { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            //  使用初始化语法调用自定义的构造函数
            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            //Console.WriteLine("Value of Point is : {0}", goldPoint.DisplayStats());
            goldPoint.DisplayStats();
            Console.WriteLine();

            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };

            Console.ReadLine();
        }
    }
}
