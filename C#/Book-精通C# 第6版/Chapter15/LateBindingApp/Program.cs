using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace LateBindingApp
{
    //  这个程序将加载一个外部库并使用晚期绑定创建一个对象
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Late Binding *****");
            //  尝试记载一个本地的CarLibrary副本
            Assembly a = null;
            try
            {
                a = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
            if (a != null)
            {
                CreateUsingLateBinding(a);
                InvokeMethodWithArgsUsingLateBinding(a);
            }

            Console.ReadLine();
        }

        static void CreateUsingLateBinding(Assembly asm)
        {
            try
            {
                //  得到Minivan类型的原数据
                Type miniVan = asm.GetType("CarLibrary.MiniVan");

                //  在运行时建立Minivan
                object obj = Activator.CreateInstance(miniVan);
                Console.WriteLine("Created a {0} using late binding!", obj);

                //  得到TurboBoost的信息
                MethodInfo mi = miniVan.GetMethod("TurboBoost");

                //  调用方法('null'意味着没有参数)
                mi.Invoke(obj, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void InvokeMethodWithArgsUsingLateBinding(Assembly asm)
        {
            try
            {
                //  首先,得到运动汽车的元数据描述
                Type sport = asm.GetType("CarLibrary.SportsCar");

                //  然后创建运动汽车
                object obj = Activator.CreateInstance(sport);

                //  调用包含参数的TurnOnRadio
                MethodInfo mi = sport.GetMethod("TurnOnRadio");
                mi.Invoke(obj, new object[] { true, 2 });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
