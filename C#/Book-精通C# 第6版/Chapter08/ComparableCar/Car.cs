using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparableCar
{
    class Car : IComparable
    {
        //  表示最大速度的常量
        public const int MaxSpeed = 100;

        //  Car属性
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        //  Car是否仍可以操纵
        private bool carIsDead;

        //  每个Car拥有一个Radio
        private Radio theMusicBox = new Radio();

        public int CarID { get; set; }


        //  构造函数
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public Car(string name, int currSp, int id)
        {
            CurrentSpeed = currSp;
            PetName = name;
            CarID = id;
        }

        public void CrankTunes(bool state)
        {
            //委托请求到内部对象
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;

                    //  使用throw关键字引发异常
                    Exception ex = new Exception(string.Format("{0} has overheated!", PetName));
                    ex.HelpLink = "http:/www.CarsRUs.com";
                    ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot");
                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrentSpeed={0}", CurrentSpeed);
            }
        }

        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp == null)
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
            else
            {
                //if (this.CarID > temp.CarID) return 1;
                //else if (this.CarID < temp.CarID) return -1;
                //else return 0;

                return this.CarID.CompareTo(temp.CarID);
            }
        }

        public static IComparer SortByPetName
        {
            get { return (IComparer)new PetNameComparer(); }
        }
    }
}
