using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PublicDelegateProblem
{
    public class Car
    {

        public delegate void CarEngineHandler(string msgForCaller);

        //  这是一个公共成员
        public CarEngineHandler listOfHandlers;

        //  触发分解的通知
        public void Accelerate(int delta)
        {
            if (listOfHandlers != null)
            {
                listOfHandlers("Sorry,this car is dead...");
            }
        }
    }
}
