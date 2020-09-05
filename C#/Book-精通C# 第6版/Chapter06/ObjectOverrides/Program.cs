using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");

            //  说明:我们希望这些都一致,以便测试Equals()和GetHashCode()方法
            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);

            //  获取对象的字符串化版本
            Console.WriteLine("p1.ToString()={0}", p1.ToString());
            Console.WriteLine("p2.ToString()={0}", p2.ToString());

            //  测试重写的Equals()
            Console.WriteLine("p1=p2?:{0}", p1.Equals(p2));


            //  测试散列码
            Console.WriteLine("Same hash codes?:{0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();

            //  修改p2的年龄并再次测试
            p2.Age = 45;
            Console.WriteLine("p1.ToString()={0}", p1.ToString());
            Console.WriteLine("p2.ToString()={0}", p2.ToString());
            Console.WriteLine("p1=p2?:{0}", p1.Equals(p2));
            Console.WriteLine("Same hash codes?:{0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();

            StaticMembersOfObject();
            Console.ReadLine();

            //Person p1 = new Person("Homer", "Simpson", 50);
            ////  使用System.Object的继承成员
            //Console.WriteLine("ToString:{0}", p1.ToString());
            //Console.WriteLine("Hash code:{0}", p1.GetHashCode());
            //Console.WriteLine("Type:{0}", p1.GetType());

            ////  让其他引用指向p1
            //Person p2 = p1;
            //object o = p2;
            //if (o.Equals(p1) && p2.Equals(o))
            //{
            //    Console.WriteLine("Same instance!");
            //}
            //Console.ReadLine();
        }

        static void StaticMembersOfObject()
        {
            // Systen.Object的静态成员
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);

            Console.WriteLine("p3 and p4 have same state:{0}", object.Equals(p3, p4));
            Console.WriteLine("p3 and p4 are pointing to same object:{0}", object.ReferenceEquals(p3, p4));
        }
    }
}
