using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CstomConversions
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int w,int h):this()
        {
            Width = w;
            Height = h;
        }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return string.Format("[Width={0};Heigth={1}]", Width, Height);
        }

        public static implicit operator Rectangle(Square s)
        {
            Rectangle r = new Rectangle();
            r.Height = s.Length;

            //  设定新矩形的长度为正方形的边长乘2
            r.Width = s.Length * 2;
            return r;
        }
    }
}
