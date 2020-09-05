using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithEnums
{
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums*****");
            //创建职员的类型
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.WriteLine();

            //输出枚举的存储
            Console.WriteLine("EmpType uses a {0} for storage.", Enum.GetUnderlyingType(typeof(EmpType)));
            Console.WriteLine();

            //输出"emp is a Contractor"
            Console.WriteLine("emp is a {0}", emp.ToString());
            Console.WriteLine();

            //输出"Contractor=100"
            Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);
            Console.WriteLine();


            EmpType emp_2 = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EnvaluateEnum(emp_2);
            EnvaluateEnum(day);
            EnvaluateEnum(cc);

            Console.ReadLine();
        }

        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir");
                    break;
            }
        }

        static void EnvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

            //获取传入参数的名称/值对
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name:{0},Value:{0:D}", enumData.GetValue(i));
            }

            Console.WriteLine();
        }
    }
}
