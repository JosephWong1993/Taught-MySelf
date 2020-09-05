using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegate
{
    //  这个委托指向任何传入两个整数并返回一个整数的方法
    public delegate int BinaryOp(int x, int y);

    //  这个类包含了BinaryOp将指向的方法
    class SimpleMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int SquareNumber(int a)
        {
            return a * a;
        }
    }
}
