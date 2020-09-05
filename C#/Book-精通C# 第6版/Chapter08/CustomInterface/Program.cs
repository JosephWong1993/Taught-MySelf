using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");

            //调用IPointy定义的Points属性
            IPointy hex = new Hexagon();
            Console.WriteLine("Points:{0}", hex.Points);
            Console.WriteLine();

            //捕获可能发生的InvalidCastException异常
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine("itfPt.Points");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            //  我们能将六角形hex2视为实现了IPointy接口吗
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if (itfPt2 != null)
                Console.WriteLine("Points:{0}", itfPt2.Points);
            else
                Console.WriteLine("OOPS!No pointy...");

            Console.WriteLine("***** Fun with Interfaces *****\n");

            //生成Shape数组
            Shape[] myShapes = { new Hexagon(), new Circle(), new Circle("JoJo") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                //回调Shape积累定义一个抽象的Draw()成员,有次所有Shape都知道如何绘制自己
                myShapes[i].Draw();

                //哪些是有棱角的
                if (myShapes[i] is IPointy)
                    Console.WriteLine("-> Points:{0}", ((IPointy)myShapes[i]).Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy", myShapes[i].PetName);

                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
                Console.WriteLine();
            }
            Console.WriteLine();

            //  获取定一个pointy项
            //   安全起见,在使用前最好检查firstPointyShape(myShapes);
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("the item has {0} points", firstPointyItem.Points);
            Console.WriteLine();

            Console.ReadLine();
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                    return s as IPointy;
            }
            return null;
        }
    }
}
