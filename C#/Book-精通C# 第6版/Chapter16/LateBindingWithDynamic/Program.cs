using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.CSharp.RuntimeBinder;

namespace LateBindingWithDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load("CarLibrary");

            //CreateUsingLateBinding(asm);

            //InvokeMethodWithDynamicKeyword(asm);

            AddWithReflection();

            AddWithDynamic();

            Console.ReadLine();
        }

        static void CreateUsingLateBinding(Assembly asm)
        {
            try
            {
                //  获取Minivan类型的元数据
                Type miniVan = asm.GetType("CarLibrary.MiniVan");

                //  在运行时创建Minivan类型
                object obj = Activator.CreateInstance(miniVan);

                //  获取TurboBoost的信息
                MethodInfo mi = miniVan.GetMethod("TurboBoost");

                //  调用方法('null'代表没有参数)
                mi.Invoke(obj, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void InvokeMethodWithDynamicKeyword(Assembly asm)
        {
            try
            {
                //  获取Minivan类型的元数据
                Type miniVan = asm.GetType("CarLibrary.MiniVan");

                //  在运行时创建Minivan并调用其方法
                dynamic obj = Activator.CreateInstance(miniVan);
                obj.TurboBoost();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddWithReflection()
        {
            Assembly asm = Assembly.Load("MathLibrary");

            try
            {
                //  获取SimpleMath类型的元数据
                Type math = asm.GetType("MathLibrary.SimpleMath");

                //  在运行时创建SimplyMath
                object obj = Activator.CreateInstance(math);

                //  获取Add方法的信息
                MethodInfo mi = math.GetMethod("Add");

                //  调用方法(包含其参数)
                object[] args = { 10, 70 };
                Console.WriteLine("Result is: {0}", mi.Invoke(obj, args));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddWithDynamic()
        {
            Assembly asm = Assembly.Load("MathLibrary");

            try
            {
                Type math = asm.GetType("MathLibrary.SimpleMath");

                dynamic obj = Activator.CreateInstance(math);
                Console.WriteLine("Result is: {0}", obj.Add(10, 70));
            }
            catch (RuntimeBinderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
