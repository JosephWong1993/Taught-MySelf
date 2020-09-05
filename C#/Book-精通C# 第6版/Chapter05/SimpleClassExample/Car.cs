using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClassExample
{
    class Car
    {
        //Car的状态
        public string petName;
        public int currSpeed;

        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        //  自定义的默认构造函数
        public Car(string pn)
        {
            petName = pn;
        }

        //  让调用者设置Car的完整"状态"
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH", petName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
