using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomEnumerator
{
    public class Garage:IEnumerable
    {
        private Car[] carArray = new Car[4];

        //启动时填充一些Car对象
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}
