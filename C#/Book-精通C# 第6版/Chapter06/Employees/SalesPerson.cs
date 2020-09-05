using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson() { }
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }

        //销售人员的奖金收销售量的影响
        public override void GiveBonus(float amount)
        {
            int salesBouns = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBouns = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBouns = 15;
                }
                else
                {
                    salesBouns = 20;
                }
            }
            base.GiveBonus(amount * salesBouns);
        }

        public override sealed void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales : {0}", SalesNumber);
        }
    }
}
