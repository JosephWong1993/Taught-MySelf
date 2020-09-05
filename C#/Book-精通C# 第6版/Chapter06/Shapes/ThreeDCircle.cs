using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    //这个类扩展了Circle并隐藏了继承的Draw()方法
    class ThreeDCircle : Circle
    {
        //隐藏任何在我之上的PetName属性
        public new string PetName { get; set; }

        //隐藏任何在我之上的Draw()实现
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }


}
