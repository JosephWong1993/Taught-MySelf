using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarEventsWithLambdas
{
    class Car
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

        //  这个委托用来与Car的事件协作
        public delegate void CarEngineHandler(object sender, CarEventArgs e);

        //  这种汽车可以发送这些事件
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public void Acclerate(int delta)
        {
            //  如果Car无法使用了,触发Exploded事件
            if (carIsDead)
            {
                if (Exploded != null)
                {
                    Exploded(this, new CarEventArgs("Sorry, this car is dead..."));
                }
            }
            else
            {
                CurrentSpeed += delta;

                //  快不能用了吗
                if (10 == MaxSpeed - CurrentSpeed
                    && AboutToBlow != null)
                {
                    AboutToBlow(this, new CarEventArgs("Careful buddy! Gonna blow!"));
                }

                //  还好着呢
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
