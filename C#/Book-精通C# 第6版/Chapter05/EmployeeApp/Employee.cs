using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    partial class Employee
    {
        //字段数据
        private string empName;
        private int empID;
        private int empAge;
        private float currPay;

        //构造函数
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }

        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
        }
    }
}
