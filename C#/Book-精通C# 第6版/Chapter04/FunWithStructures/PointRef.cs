using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithStructures
{
    class PointRef
    {
        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        //结构的字段
        public int X;
        public int Y;

        //将(x,y)坐标增加1
        public void Increment()
        {
            X++; Y++;
        }

        public void Decremnet()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("X={0},Y={1}", X, Y);
        }

    }

    struct Point
    {
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        //结构的字段
        public int X;
        public int Y;

        //将(x,y)坐标增加1
        public void Increment()
        {
            X++; Y++;
        }

        public void Decremnet()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("X={0},Y={1}", X, Y);
        }
    }
}
