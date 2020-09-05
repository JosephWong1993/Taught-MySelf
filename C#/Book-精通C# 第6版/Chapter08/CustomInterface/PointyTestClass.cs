using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    class PointyTestClass:IPointy
    {
        public byte Points
        {
            get { throw new NotImplementedException(); }
        }

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
