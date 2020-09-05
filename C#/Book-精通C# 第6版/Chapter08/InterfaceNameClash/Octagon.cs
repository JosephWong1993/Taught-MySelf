using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //  对某个接口显式绑定Draw()
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer");
        }
    }
}
