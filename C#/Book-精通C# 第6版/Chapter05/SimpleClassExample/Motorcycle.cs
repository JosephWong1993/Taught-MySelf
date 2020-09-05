using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;

        //  表示司机名称的新成员
        public string driverName;

        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee HaaaaaeeWWW!");
            }
        }

        public void SetDriveName(string name)
        {
            this.driverName = name;
        }

        ////  构造函数链
        //public Motorcycle()
        //{
        //    Console.WriteLine("In default ctor");
        //}
        //public Motorcycle(int intensity)
        //    : this(intensity, "")
        //{
        //    Console.WriteLine("In ctor taking an int");
        //}
        //public Motorcycle(string name)
        //    : this(0, name)
        //{
        //    Console.WriteLine("In ctor taking a string");
        //}

        ////  "主"构造函数完成所有实际工作
        //public Motorcycle(int intensity, string name)
        //{
        //    Console.WriteLine("In master ctor");
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}

        //使用可选参数的单个构造函数
        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }
}
