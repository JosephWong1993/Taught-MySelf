using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        void IDrawable.Draw()
        {
            throw new NotImplementedException();
        }
        void IPrintable.Draw()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfSides()
        {
            return 4;
        }
    }
}
