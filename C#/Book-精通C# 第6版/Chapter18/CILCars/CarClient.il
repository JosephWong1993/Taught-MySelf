//  外部程序集调用
.assembly extern mscorlib
{
    .publickeytoken=(B7 7A 5C 56 19 34 E0 89)
    .ver 4:0:0:0
}

.assembly extern CILCars
{
    .ver 1:0:0:0
}

//  我们的执行程序集
.assembly CILClient
{
    .hash algorithm 0x00008004
    .ver 1:0:0:0
}

.module CarClient.exe

//  Program类型的实现
.namespace CarClient
{
    .class private auto ansi beforefieldinit Program
        extends [mscorlib]System.Object
    {
        .method private hidebysig static void
            Main(string[] args) cil managed
        {
            //  为*.exe的入口做标记
            .entrypoint
            .maxstack 8

            //  声明局部CILCar变量并为栈上的ctor请求输入值
            .locals init ([0] class [CILCars]CILCars.CILCar myCilCar)
            ldc.i4 55
            ldstr "Junior"

            //  构建新的CilCar;存储并加载引用
            newobj instance void [CILCars]CILCars.CILCar::.ctor(int32,string)
            stloc.0
            ldloc.0

            //  调用Display()并传入栈顶值
            call void [CILCars] CILCars.CILCarInfo::Display(class [CILCars]CILCars.CILCar)
            ret
        }
    }
}