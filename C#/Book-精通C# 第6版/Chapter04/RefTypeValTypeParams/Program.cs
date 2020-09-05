using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //按值传递引用类型
            Console.WriteLine("*****Passing Person object by value *****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call,Person is:");
            fred.Display();
            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call,Person is:");
            fred.Display();
            Console.WriteLine();

            Console.WriteLine("***** Passing Peoson object by reference *****");
            Person mel = new Person("Mel", 23);
            Console.WriteLine("Before by ref call,Person is:");
            mel.Display();
            SendAPersonByReference(ref mel);
            Console.WriteLine("After by ref call,Person is:");
            mel.Display();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void SendAPersonByValue(Person p)
        {
            //改变p的年龄
            p.personAge = 99;

            //调用者能看到这个重新赋值吗?
            p = new Person("Nikki", 99);
        }

        static void SendAPersonByReference(ref Person p)
        {
            //改变"p"的一些数据
            p.personAge = 555;

            //"p"现在指向了堆上的一个新对象
            p = new Person("Nikki", 999);
        }
    }
}
