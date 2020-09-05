using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace VehicleDescriptionAttributeReaderLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Value of VehicleDescriptionAttribute *****\n");
            ReflectAttributesUsingLateBinding();
            Console.ReadLine();
        }

        private static void ReflectAttributesUsingLateBinding()
        {
            try
            {
                //  加载本地的AttributedCarLibrary的副本
                Assembly asm = Assembly.Load("AttributedCarLibrary");

                //  得到VehicleDescriptionAttribute的类型信息
                Type vehicleDesc = asm.GetType("AttributedCarLibrary.VehicleDescriptionAttribute");

                //  得到Description属性的信息
                PropertyInfo propDesc = vehicleDesc.GetProperty("Description");

                //  得到程序集中的所有类型
                Type[] types = asm.GetTypes();

                //  遍历每个类型.得到所有的VehicleDescriptionAttributes
                foreach (Type t in types)
                {
                    object[] objs = t.GetCustomAttributes(vehicleDesc, false);

                    //  遍历每个VehicleDescriptionAttribute并使用晚期绑定输出描述
                    foreach (object o in objs)
                    {
                        Console.WriteLine("-> {0}: {1}\n", t.Name, propDesc.GetValue(o, null).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
