using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoProps
{
    class Garage
    {
        public int NumberOfCars { get; set; }

        public Car MyAuto { get; set; }

        //必须使用构造函数重写分配给隐藏后备字段的默认值
        public Garage()
            : this(car: new Car(), number: 1) { }
        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
