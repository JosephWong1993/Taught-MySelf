using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDelegate
{
    public class Car
    {
        //  内部状态数据
        public string PetName { get; set; }
        public int MaxSpeed { get; set; }
        public int CurrentSpeed { get; set; }

        //  汽车能用还是不能用
        private bool carIsDead;

        //  类构造函数
        public Car()
            : this(name: string.Empty, maxSp: 100, currSp: 0) { }
        public Car(string name, int maxSp, int currSp)
        {
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }

        //  1)定义委托类型
        public delegate void CarEngineHandler(string msgForCaller);

        //  2)定义每个委托类型的的成员变量
        private CarEngineHandler listOfHandlers;

        //  3)想调用者添加注册函数
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
            //listOfHandlers = (CarEngineHandler)Delegate.Combine(listOfHandlers, methodToCall);
        }

        //  4)实现Accelerate()方法已在某些情况下调用委托的调用列表
        //  如果汽车不能用了,触发引爆事件
        public void Accelerate(int delta)
        {
            //If this car is "dead",send dead message.
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers("Sorry,this car is dead...");
                }
            }
            else
            {
                CurrentSpeed += delta;

                //  快不能用了吗
                if (10 == (MaxSpeed - CurrentSpeed)
                    && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy!Gonna blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
            //listOfHandlers = (CarEngineHandler)Delegate.Remove(listOfHandlers, methodToCall);
        }
    }
}
