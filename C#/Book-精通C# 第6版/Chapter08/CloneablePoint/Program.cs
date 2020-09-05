using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            Console.WriteLine("Cloned p3 and stored new Point in p4");
            //指向同一个对象的两个引用
            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();

            Console.WriteLine("Befero modification:");
            Console.WriteLine("p3:{0}", p3);
            Console.WriteLine("p4:{0}", p4);
            p4.desc.PetName = "My new Point";
            p4.X = 9;

            Console.WriteLine("\nChenaged p4.desc.petName and p4.X");
            Console.WriteLine("After modification");
            Console.WriteLine("p3:{0}", p3);
            Console.WriteLine("p4:{0}", p4);

            Console.ReadLine();
        }
    }
}
