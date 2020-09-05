.assembly extern mscorlib
{
    .publickeytoken = (B7 7A 5C 56 19 34 E0 89)
    .ver 4:0:0:0
}

//  我们的程序集
.assembly CILTypes
{
    .ver 1:0:0:0
}

//  单文件程序集的模块
.module CILTypes.dll

//  我们的程序集有一个命名空间
.namespace MyNamespace
{
    //  定义一个接口
    .class public interface IMyInterface{}

    //  在CIL中继承一个接口
    .class public interface IMyOtherInterface
        implements MyNamespace.IMyInterface{}

    //  一个简单的基类
    .class public MyBaseClass
    {
        .field private string stringField="hello!"
        .field private int32 intField=int32(42)

        .method public hidebysig specialname rtspecialname
            instance void .ctor(string s,int32 i) cil managed
        {
            //  TODO:加入实现代码
        }

        // .class public hidebysig specialname instance string get_TheString() cil managed
        // {
        //     //  TODO:加入实现代码
        // }

        // .class public hidebysig specialname instance void set_ThewString(string 'value') cil managed
        // {
        //     //  TODO:加入实现代码
        // }

        // .property instance string TheString()
        // {
        //     .get instance string MyNamespace.MyBaseClass::get_TheString()
        //     .set instance void MyNamespace.MyBaseClass::set_ThewString(string)
        // }

        .method public hidebysig static void MyMethod(int32 inputInt,
            int32& refInt,
            class [mscorlib]System.Collections.ArrayList ar,
            [out] int32& outputInt)cil managed
        {
            //  TODO:...
        }

        .method public hidebysig instance void Speak() cil managed
        {
            //  在这个方法的有效范围内，正好有一个值1（字符串变量）是在栈中
            .maxstack 1
            ldstr "Hello there..."
            call void [mscorlib]System.Console::WriteLine(string)
        }

        .method public hidebysig static void MyLocalVariables() cil managed
        {
            .maxstack 8
            //  定义3个本地变量
            .locals init ([0] string myStr, [1] int32 myInt,[2] object myObj)
            //  加载字符串到虚拟执行栈中
            ldstr "CIL code is fun"
            //  弹出当前栈的值，并存入本地变量[0]
            stloc.0

            //  加载常量到类型i4(int32的简写),设置值为33
            ldc.i4 33
            //  弹出当前的值，并存入本地变量[1]
            stloc.1

            //  创建一个新对象并放在栈上
            newobj instance void [mscorlib]System.Object::.ctor()
            //  弹出当前栈的值，并存入本地变量[2]
            stloc.2
            ret
        }
    }

    .class public MyDerivedClass 
        extends MyNamespace.MyBaseClass
        implements MyNamespace.IMyInterface{} 

    //  结构定义总是密封的
    .class public sealed MyStruct
        extends [mscorlib]System.ValueType{}

    //  定义一个结构的简便方法
    // .class public sealed value MyStruct{}

    //  一个枚举
    .class public sealed MyEnum
        extends [mscorlib]System.Enum
    {
        .field public static literal valuetype MyNamespace.MyEnum A =int32(0)
        .field public static literal valuetype MyNamespace.MyEnum B=int32(1)
        .field public static literal valuetype MyNamespace.MyEnum C=int32(2)
    }

    //  快捷方式定义枚举
    // .class public sealed enum MyEnum{}
}