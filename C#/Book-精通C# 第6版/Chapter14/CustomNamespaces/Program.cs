using System;
using MyShapes;
using Chapter14.My3DShapes;
using The3DHexagon = Chapter14.My3DShapes.Hexagon;
using bfHome = System.Runtime.Serialization.Formatters.Binary;

namespace CustomNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            bfHome.BinaryFormatter b = new bfHome.BinaryFormatter();
            //  这是在创建My3DShapes.Hexagon类
            The3DHexagon h = new The3DHexagon();
            Chapter14.My3DShapes.Circle c = new Chapter14.My3DShapes.Circle();
            MyShapes.Square s = new MyShapes.Square();
        }
    }
}
