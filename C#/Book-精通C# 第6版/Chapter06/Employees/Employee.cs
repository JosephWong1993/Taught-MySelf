using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    partial class Employee
    {
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }

            //  假设还有其他成员来表示牙齿,健康保险金等
            public double CoputerPayDeduction()
            {
                return 125.0D;
            }
        }

        //字段数据
        protected string empName;
        protected int empID;
        protected int empAge;
        protected float currPay;
        protected string empSSN;
        private BenefitPackage empBenefits = new BenefitPackage();

        //公开对象的保险金行为
        public double GetBenefitCost()
        {
            return empBenefits.CoputerPayDeduction();
        }

        //通过自定义属性公开对象
        protected BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        //构造函数
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay, string.Empty) { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            SSN = ssn;
        }
    }
}
