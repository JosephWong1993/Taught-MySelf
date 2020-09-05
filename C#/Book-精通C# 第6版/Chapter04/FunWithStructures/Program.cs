using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            //创建初始Point
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            //调整X和Y的值
            myPoint.Increment();
            myPoint.Decremnet();
            Console.WriteLine();

            LocalValueTypes();

            ValueTypeAssignment();

            ReferenceTypeAssignment();

            ValueTypeContainingRefType();

            Console.ReadLine();
        }

        static void LocalValueTypes()
        {
            //"int"其实是System.Int32结构
            int i = 0;

            //Point是结构类型
            Point p = new Point();
            //i和p在这里弹出栈
            Console.WriteLine();
        }

        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");
            Point p1 = new Point(10, 10);
            Point p2 = p1;

            //  输出两个Point
            p1.Display();
            p2.Display();

            //  改变p1.X并且输出.p2.X不会改变
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();

            Console.WriteLine();
        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            //输出两个Point ref
            p1.Display();
            p2.Display();

            //改变p1.X并且再次输出
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            //创建第一个Rectangle
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("Firet Rect", 10, 10, 50, 50);

            //现在将一个新的Rectangle的值设为r1
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            //改变r2的值
            Console.WriteLine("-> Changeing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;

            //输出两个rectangle的值
            r1.Display();
            r2.Display();
        }
    }
}
