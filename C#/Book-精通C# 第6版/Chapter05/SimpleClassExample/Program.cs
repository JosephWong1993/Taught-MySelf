using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {

            FunWithClassTypes();

            MakeSomeBikes();

            FunWithStaticData();

            Console.ReadLine();
        }

        static void FunWithClassTypes()
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            //  创建一个叫Chuck的Car,速度为10MPH
            Car chuck = new Car();
            chuck.PrintState();
            Console.WriteLine();

            //  创建一个叫Mary的Car,速度为0MPH
            Car mary = new Car("Mary");
            mary.PrintState();
            Console.WriteLine();

            //  创建一个叫Daisy的Car,速度为75MPH
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            //  分配和设置Car对象
            Car myCar = new Car();

            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            //  将Car加速几次,然后就输出新的状态
            for (int i = 0; i < 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.WriteLine();

            Console.WriteLine("***** Fun with class Types *****\n");

            //创建Motorcycle
            Motorcycle c = new Motorcycle(5);
            c.SetDriveName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.driverName);
            Console.WriteLine();
        }

        static void MakeSomeBikes()
        {
            Motorcycle m1 = new Motorcycle();
            Console.WriteLine("Name={0},Intensity={1}", m1.driverName, m1.driverIntensity);

            Motorcycle m2 = new Motorcycle(name: "Tihy");
            Console.WriteLine("Name={0},Intensity={1}", m2.driverName, m2.driverIntensity);

            Motorcycle m3 = new Motorcycle(7);
            Console.WriteLine("Name={0},Intensity={1}", m3.driverName, m3.driverIntensity);

            Console.WriteLine();
        }

        static void FunWithStaticData()
        {
            Console.WriteLine("***** Fun with Static Data *****\n");
            SavingsAccount s1 = new SavingsAccount(50);

            Console.WriteLine("Interest Rate is : {0}", SavingsAccount.GetInterestRate());
            SavingsAccount.SetInterestRate(0.08D);

            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine("Interset Rate is : {0}", SavingsAccount.GetInterestRate());
            Console.WriteLine();
        }
    }
}
