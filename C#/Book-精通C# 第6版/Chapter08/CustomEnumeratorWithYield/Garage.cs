using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomEnumeratorWithYield
{
    public class Garage 
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
            foreach (Car c in carArray)
            {
                yield return c;
            }
        }

        public IEnumerable GetTheCars(bool ReturnReseversed)
        {
            if (ReturnReseversed)
            {
                for (int i = carArray.Length; i != 0; i--)
                {
                    yield return carArray[i - 1];
                }
            }
            else
            {
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }
    }
}
