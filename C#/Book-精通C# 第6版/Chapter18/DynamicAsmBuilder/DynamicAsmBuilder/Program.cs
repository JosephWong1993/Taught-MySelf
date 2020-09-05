using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace DynamicAsmBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Amazing Dynamic Assembly Builder App *****");
            //  得到当前线程的应用程序域
            AppDomain curAppDomain = Thread.GetDomain();

            //  使用辅助函数f(x)创建动态程序集
            CreateMyAsm(curAppDomain);
            Console.WriteLine("-> Finished creating MyAssembly.dll");

            //  加载新的程序集
            Console.WriteLine("-> Loading MyAssembly.dll from file");
            Assembly a = Assembly.Load("MyAssembly");

            //  得到HelloWorld类型
            Type hello = a.GetType("MyAssembly.HelloWorld");

            //  创建HelloWorld对象并调用正确的构造函数
            Console.WriteLine("-> Enter message to pass HelloWorld class: ");
            string msg = Console.ReadLine();
            object[] ctorArgs = new object[1];
            ctorArgs[0] = msg;
            object obj = Activator.CreateInstance(hello, ctorArgs);

            //  调用SayHello()并且显示返回的字符串
            Console.WriteLine("-> Calling SayHello() via late binding.");
            MethodInfo mi = hello.GetMethod("SayHello");
            mi.Invoke(obj, null);

            //  触发GetMsg()
            mi = hello.GetMethod("GetMsg");
            Console.WriteLine(mi.Invoke(obj, null));

            Console.ReadLine();
        }

        //  调用者传入一个AppDomain类型
        private static void CreateMyAsm(AppDomain curAppDomain)
        {
            //  建立通用的的程序集特征
            AssemblyName assemblyName = new AssemblyName()
            {
                Name = "MyAssembly",
                Version = new Version("1.0.0.0"),
            };

            //  使用当前AppDomain创建一个新的程序集
            AssemblyBuilder assembly = curAppDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);

            //  鉴于我们构造的是一个单文件程序集，模块的名字就是程序集的名字
            ModuleBuilder module = assembly.DefineDynamicModule("MyAssembly", "MyAssembly.dll");

            //  定义一个公共类MyAssembly.HelloWorld
            TypeBuilder helloWorldClass = module.DefineType("MyAssembly.HelloWorld", TypeAttributes.Public);

            //  定义私有字符串成员变量theMessage
            FieldBuilder msgField = helloWorldClass.DefineField("theMessage",
                Type.GetType("System.String"), FieldAttributes.Private);

            //  创建一个自定义的构造函数，它只有一个System.String参数
            Type[] constructorArgs = new Type[1];
            constructorArgs[0] = typeof(string);
            ConstructorBuilder constructor = helloWorldClass.DefineConstructor(MethodAttributes.Public,
                CallingConventions.Standard,
                constructorArgs);

            //  产生必要的CIL代码到这个构造函数
            ILGenerator constructorIL = constructor.GetILGenerator();
            constructorIL.Emit(OpCodes.Ldarg_0);
            Type objectClass = typeof(object);
            ConstructorInfo superConstructor = objectClass.GetConstructor(new Type[0]);
            constructorIL.Emit(OpCodes.Call, superConstructor); //  调用基类的构造函数
            //  加载对象的this指针到栈上
            constructorIL.Emit(OpCodes.Ldarg_0);
            //  加载输入参数到虚拟栈上并存储在msgField中
            constructorIL.Emit(OpCodes.Ldarg_1);
            constructorIL.Emit(OpCodes.Stfld, msgField);    //  赋值msgField
            constructorIL.Emit(OpCodes.Ret);    //  返回

            //  重新插入默认构造函数
            helloWorldClass.DefineDefaultConstructor(MethodAttributes.Public);

            //  创建GetMsg()方法
            MethodBuilder getMsgMethod = helloWorldClass.DefineMethod("GetMsg", MethodAttributes.Public,
                typeof(string), null);
            ILGenerator methodIL = getMsgMethod.GetILGenerator();
            methodIL.Emit(OpCodes.Ldarg_0);
            methodIL.Emit(OpCodes.Ldfld, msgField);
            methodIL.Emit(OpCodes.Ret);

            //  创建SayHello()方法
            MethodBuilder sayHiMethod = helloWorldClass.DefineMethod("SayHello", 
                MethodAttributes.Public, null, null);
            methodIL = sayHiMethod.GetILGenerator();
            //  输出一行到控制台
            methodIL.EmitWriteLine("Hello from the HelloWorld class!");
            methodIL.Emit(OpCodes.Ret);

            //  创建类HelloWorld(Baking是创建一个类型的正式术语)
            helloWorldClass.CreateType();

            //  将这个程序集保存到文件（可选）
            assembly.Save("MyAssembly.dll");
        }
    }
}
