using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    public interface IPointy
    {
        byte Points { get; }

        //隐式公共的和抽象的
        byte GetNumberOfPoints();
    }
}
