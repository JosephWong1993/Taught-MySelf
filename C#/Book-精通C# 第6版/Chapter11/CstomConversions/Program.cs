using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CstomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Conversions *****\n");

            //  创建一个矩形
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();

            Console.WriteLine();

            //  根据矩形的高度将r转行成为正方形
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            Console.WriteLine();

            //  将Rectangle转为Square来调用方法
            Rectangle rect = new Rectangle(10, 5);
            DrawSquare((Square)rect);

            Console.WriteLine();

            //  转换int为Square
            Square sq2 = (Square)90;
            Console.WriteLine("sq2 = {0}", sq2);

            //  转换Square为int
            int side = (int)sq2;
            Console.WriteLine("Side length of sq2 = {0}", side);

            Console.WriteLine();

            //  隐式强制类型转换成功
            Square s3 = new Square();
            s3.Length = 7;
            Rectangle rect2 = s3;
            Console.WriteLine("rect2 = {0}", rect2);

            //  显式强制类型转换语法也成功
            Square s4 = new Square();
            s4.Length = 3;
            Rectangle rect3 = (Rectangle)s4;
            Console.WriteLine("rect3 = {0}", rect3);

            Console.ReadLine();
        }

        static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}
