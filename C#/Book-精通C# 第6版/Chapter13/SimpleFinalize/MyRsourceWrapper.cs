using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFinalize
{
    class MyRsourceWrapper
    {
        //  编译时错误
        //protected override void Finalize() { }

        ~MyRsourceWrapper()
        {
            //  清除这里非托管的资源

            //  当被销毁时蜂鸣
            Console.Beep();
        }
    }
}
