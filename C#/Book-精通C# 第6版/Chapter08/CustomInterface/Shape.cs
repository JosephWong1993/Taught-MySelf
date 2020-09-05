using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    abstract class Shape
    {
        public string PetName { get; set; }

        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        //强制所有子类来定义如何被呈现
        public abstract void Draw();
    }
}
