using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");
            Octagon oct = new Octagon();

            //  现在必须使用转换来访问Draw()成员
            IDrawToForm itform = (IDrawToForm)oct;
            itform.Draw();

            //  如果以后不需要接口变量,可以简化成这个形式
            ((IDrawToPrinter)oct).Draw();

            //  也可以用"is"关键字
            if (oct is IDrawToMemory)
                ((IDrawToMemory)oct).Draw();

            Console.ReadLine();
        }
    }
}
