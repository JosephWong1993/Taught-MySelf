using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadOps
{
    //  仅是一个简单的C#类
    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}]", this.X, this.Y);
        }

        //  重载+操作符
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        //  重载-操作符
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Point operator +(Point p1, int change)
        {
            return new Point(p1.X + change, p1.Y + change);
        }

        public static Point operator +(int change, Point p1)
        {
            return new Point(p1.X + change, p1.Y + change);
        }

        //  将传入的Point的X/Y值加1
        public static Point operator ++(Point p1)
        {
            return new Point(p1.X + 1, p1.Y + 1);
        }

        // 将传入的Point的X/Y的值减1
        public static Point operator --(Point p1)
        {
            return new Point(p1.X - 1, p1.Y - 1);
        }

        public override bool Equals(object o)
        {
            if (o == null) return false;
            return o.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        //  现在,让我们来重载==和!=操作符
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }

        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
                return 1;
            if (this.X < other.X && this.Y < other.Y)
                return -1;
            else
                return 0;
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static bool operator >(Point p1, Point p2)
        {
            return p1.CompareTo(p2) > 0;
        }

        public static bool operator <=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) <= 0;
        }

        public static bool operator >=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) >= 0;
        }
    }
}
