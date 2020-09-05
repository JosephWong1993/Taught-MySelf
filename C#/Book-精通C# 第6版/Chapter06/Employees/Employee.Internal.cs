using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    abstract partial class Employee
    {
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name must be less than characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public string SSN
        {
            get { return empSSN; }
            set { empSSN = value; }
        }

        //方法
        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name:{0}", empName);
            Console.WriteLine("ID:{0}", empName);
            Console.WriteLine("Age:{0}", empAge);
            Console.WriteLine("Pay:{0}", currPay);
        }

        ////访问方法(get方法)
        //public string GetName()
        //{
        //    return empName;
        //}

        ////  修改方法
        //public void SetName(string name)
        //{
        //    //  在赋值之前检查输入的值
        //    if (name.Length > 15)
        //    {
        //        Console.WriteLine("Error! Name must be less than characters!");
        //    }
        //    else
        //    {
        //        empName = name;
        //    }
        //}
    }
}
