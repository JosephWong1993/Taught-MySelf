using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicInheritance
{
    //  MiniVan是一个Car
    class MiniVan : Car
    {
        public void TestMethod()
        {
            //  正确!可以在派生类型中访问父类的公共成员
            Speed = 10;

            //  错误!不能再派生类型中访问父类的私有成员
            //currSpeed = 10;
        }
    }
}
