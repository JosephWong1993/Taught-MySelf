using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            //  使用get/set方法来和对象的名字进行交互
            emp.Name = ("Marv");
            Console.WriteLine("Employee is named: {0}", emp.Name);
            Console.WriteLine();

            Employee emp2 = new Employee();
            emp2.Name = ("Xena the warrior princess");

            Console.ReadLine();
        }
    }
}
