using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloneablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();
        public Point()
        {

        }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }

        //  重写Object.ToString()
        public override string ToString()
        {
            return string.Format("X={0};Y={1};Name={2};\nID={3}", X, Y, desc.PetName, desc.PointID);
        }

        //  返回当前对象的副本
        public object Clone()
        {
            // 首先获取签复制
            Point newPoint = (Point)this.MemberwiseClone();

            //然后填充间距
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;

            return newPoint;
        }
    }
}
