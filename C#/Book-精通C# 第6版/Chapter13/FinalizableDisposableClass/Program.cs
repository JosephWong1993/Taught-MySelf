using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalizableDisposableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Dispose()/Destructor Combo Platter *****");

            //  手动调用Dispose(),这不会调用终结器
            MyRsourceWrapper rw = new MyRsourceWrapper();
            rw.Dispose();

            //  不调用Dispose(),这会触发终结器,并引起嘟嘟声
            MyRsourceWrapper rw2 = new MyRsourceWrapper();
        }
    }
}
