using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericPoint
{
    public struct Point<T>
    {
        //  泛型状态数据
        private T xPos;
        private T yPos;

        //  泛型构造函数
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        //  泛型属性
        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString()
        {
            return String.Format("[{0},{1}]", xPos, yPos);
        }

        //  在C#中,default关键字被重载
        //  和泛型一起使用时,它表示一个类型参数的默认值
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
    }
}
