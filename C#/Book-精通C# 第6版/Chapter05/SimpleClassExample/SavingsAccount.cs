using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClassExample
{
    /// <summary>
    /// 一个简单的储蓄账户类
    /// </summary>
    class SavingsAccount
    {
        //实例级别的数据
        public double currBalance;

        //静态数据点
        public static double currInterestRate;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        //  获取/设置利率的静态成员
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
