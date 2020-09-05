using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson danny = new SalesPerson();
            danny.Name = "Danny";
            danny.Age = 31;
            danny.SalesNumber = 50;

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);

            //错误!不能从对象实例中直接访问受保护数据
            //Employee emp = new Employee();
            //emp.empName = "Fred";

            double cost = chucky.GetBenefitCost();

            //  定义福利等级
            Employee.BenefitPackage.BenefitPackageLevel myBendfitLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;

            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void CastingExamples()
        {
            //Manager是(is-a) System.Object,因此我们刚好可以在object变量中存储Manage引用
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager)frank);

            //Manager同样是Employee
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            //  PTSalesPerson是SalesPerson
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);
        }

        static void GivePromotion(Employee emp)
        {
            //增加工资
            //在公司车库新增停车位

            Console.WriteLine("{0} was promoted!", emp.Name);

            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sales(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            if (emp is Manager)
            {
                Console.WriteLine("{0} has {1} stock options...",emp.Name,((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }


    }
}
