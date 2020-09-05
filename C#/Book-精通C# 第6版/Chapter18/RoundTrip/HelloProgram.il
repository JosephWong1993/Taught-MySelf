
//  Microsoft (R) .NET Framework IL Disassembler.  Version 3.5.21022.8
//  Copyright (c) Microsoft Corporation.  All rights reserved.



//  引用的程序集
// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}

.assembly extern System.Windows.Forms
{
  .publickeytoken=(B7 7A 5C 56 19 34 E0 89)
  .ver 4:0:0:0
}

//我们的程序集
.assembly HelloProgram
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module HelloProgram.exe
// MVID: {F5915CCE-82AA-4A05-8129-D75AA3D8E121}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x00000000029D0000


// =============== CLASS MEMBERS DECLARATION ===================
//  Program类的定义
.class private auto ansi beforefieldinit Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    //  标识出这个方法是可执行文件的入口点
    .entrypoint
    // 代码大小       19 (0x13)
    .maxstack  8
    //  TODO: 编写新的CIL代码
    ldstr "CIL is way cool"
    call valuetype [System.Windows.Forms]
      System.Windows.Forms.DialogResult
      [System.Windows.Forms]
      System.Windows.Forms.MessageBox::Show(string)
    pop
    ret
  } // end of method Program::Main

  //  默认构造函数
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // 代码大小       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class Program

// =============================================================

// *********** 反汇编完成 ***********************
// 警告: 创建了 Win32 资源文件 F:\C#\精通C#(第6版)\Chapter18\HelloProgram.res
