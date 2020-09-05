using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Interface Hierarchy *****");

            //  从对象级别调用
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            //显式获取IAdvanedDraw
            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();

            Console.ReadLine();
        }
    }
}
