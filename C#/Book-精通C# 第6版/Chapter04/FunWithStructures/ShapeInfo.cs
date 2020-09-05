using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithStructures
{
    class ShapeInfo
    {
        public string infoString;

        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }

    struct Rectangle
    {
        //Rectangle结构包含一个引用类型成员
        public ShapeInfo rectInfo;

        public int rectTop, rectLeft, rectBottom, rectRight;

        public Rectangle(string info, int top, int bottom, int left, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectBottom = bottom;
            rectLeft = left;
            rectRight = right;
        }

        public void Display()
        {
            Console.WriteLine("String={0},Top={1},Bottom={2},Left={3},Right={4}",
                rectInfo.infoString,
                rectTop, rectBottom, rectLeft, rectRight);

        }
    }
}
