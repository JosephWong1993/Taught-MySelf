.assembly extern mscorlib
{
    .publickeytoken=(B7 7A 5C 56 19 34 E0 89)
    .ver 4:0:0:0
}

.assembly extern System.Windows.Forms
{
    .publickeytoken=(B7 7A 5C 56 19 34 E0 89)
    .ver 4:0:0:0
}

//  定义这个单文件程序集
.assembly CILCars
{
    .hash algorithm 0x00008004
    .ver 1:0:0:0
}

.module CILCars.dll

//  实现CILCars.CILCar类
.namespace CILCars
{
    .class public auto ansi beforefieldinit CILCar
        extends [mscorlib]System.Object
    {
        //  CILCar的数据字段
        .field public string petName
        .field public int32 currSpeed

        //  自定义构造函数允许调用者给数据字段赋值
        .method public hidebysig specialname rtspecialname
            instance void .ctor(int32 c,string p) cil managed
        {
            .maxstack 8

            //  加载第一个参数到栈上并调用基类的构造函数
            ldarg.0 // "this"对象,不是int32!
            call instance void [mscorlib]System.Object::.ctor()

            //  加载第一个第二个参数到栈上
            ldarg.0 //  "this"对象
            ldarg.1 //  int32参数

            //  存储栈顶的成员(int32)到currSpeed字段
            stfld int32 CILCars.CILCar::currSpeed

            //  加载字符串参数并且存储到petName字段
            ldarg.0 //  "this"对象
            ldarg.2 //  string参数
            stfld string CILCars.CILCar::petName
            ret
        }
    }

    .class public auto ansi beforefieldinit CILCarInfo
        extends [mscorlib]System.Object
    {
        .method public hidebysig static void
            Display(class CILCars.CILCar c) cil managed
        {
            .maxstack 8

            //  需要一个局部的字符串变量
            .locals init ([0] string caption)

            //  加载字符串和传入的CILCar到栈上
            ldstr "{0}'s speed is:"
            ldarg.0

            //  将CILCar的petName放到栈上,然后调用静态的String.Format()方法
            ldfld string CILCars.CILCar::petName
            call string [mscorlib]System.String::Format(string,object)
            stloc.0

            //  现在加载currSpeed字段的值,取得它的字符串表示(调用ToString())
            ldarg.0
            ldflda int32 CILCars.CILCar::currSpeed
            call instance string [mscorlib]System.Int32::ToString()
            ldloc.0

            //  现在调用MessageBox.Show()方法并传入加载的值
            call valuetype [System.Windows.Forms]System.Windows.Forms.DialogResult
                [System.Windows.Forms]System.Windows.Forms.MessageBox::Show(string,string)

            pop
            ret
        }
    }
}