using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDispose
{
    //  实现IDisposable
    class MyResourceWrapper:IDisposable
    {
        //  对象用户应该在完成使用这个对象时调用这个方法
        public void Dispose()
        {
            //  这里清除非托管资源
            
            //  抛弃包含的其他可处置对象

            //  出于测试目的
            Console.WriteLine("***** In Dispose! *****");
        }
    }
}
