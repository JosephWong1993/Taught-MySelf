using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Frin with Query Expressions *****");

            //  这个数组将是测试的基础
            ProductInfo[] itemsInStock = new[]{
                new ProductInfo(){Name="Mac's Coffee",Description="Coffee with TEETH",NumberInStock=24},
                new ProductInfo(){Name="Milk Maid Milk",Description="Milk cow's love",NumberInStock=100},
                new ProductInfo(){Name="Pure Silk Tofu",Description="Bland as Possible",NumberInStock=120},
                new ProductInfo(){Name="Cruchy Pops",Description="Cheezy, peppery goodness",NumberInStock=2},
                new ProductInfo(){Name="RipOff Water",Description="From the tap to your wallet",NumberInStock=100},
                new ProductInfo(){Name="Classic Valpo Pizza",Description="Everyone loves pizza!",NumberInStock=73}
            };

            SelectEveryThing(itemsInStock);
            Console.WriteLine();

            ListProductNames(itemsInStock);
            Console.WriteLine();

            GetOverstock(itemsInStock);
            Console.WriteLine();

            GetNameAndDescription(itemsInStock);
            Console.WriteLine();

            Array objs = GetProhjectedSubset(itemsInStock);
            foreach (Object o in objs)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();

            GetCountFromQuery();
            Console.WriteLine();

            ReverseEverything(itemsInStock);
            Console.WriteLine();

            AlphabetizeProductNames(itemsInStock);
            Console.WriteLine();

            DisplayDiff();
            Console.WriteLine();

            DisplayIntersection();
            Console.WriteLine();

            DisplayUnion();
            Console.WriteLine();

            DisplayConcat();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void SelectEveryThing(ProductInfo[] products)
        {
            //  得到所有的对象
            Console.WriteLine("All product details");
            var allProducts = from p in products select p;

            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void ListProductNames(ProductInfo[] products)
        {
            //  只是提取产品的名字
            Console.WriteLine("Only product names:");

            var names = from p in products select p.Name;

            foreach (var n in names)
            {
                Console.WriteLine("Name: {0}", n);
            }
        }

        static void GetOverstock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items!");

            //  只获取库存量大于25的项
            var overstock = from p in products
                            where p.NumberInStock > 25
                            select p;

            foreach (ProductInfo c in overstock)
            {
                Console.WriteLine(c.ToString());
            }
        }

        static void GetNameAndDescription(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");
            var nameDesc = from p in products
                           select new { p.Name, p.Description };
            foreach (var item in nameDesc)
            {
                //  也可以直接使用Name和Description属性
                Console.WriteLine(item.ToString());
            }
        }

        static Array GetProhjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description };

            //  将匿名对象集映射为Array对象
            return nameDesc.ToArray();
        }

        static void GetCountFromQuery()
        {
            string[] currentVIdeoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Stock 2" };

            //  获取查询出的总数
            int numb = (from g in currentVIdeoGames where g.Length > 6 select g).Count();

            //  打印项数
            Console.WriteLine("{0} items honnor the LINQ query.", numb);
        }

        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Product in reverse:");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            //  按字母顺序获取产品的名称
            //var subset = from p in products
            //             orderby p.Name ascending
            //             select p;
            var subset = from p in products
                         orderby p.Name descending
                         select p;

            Console.WriteLine("Ordered by Name");
            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static void DisplayDiff()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);

            Console.WriteLine("Here is what you don't have,but I do:");
            foreach (string s in carDiff)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carIntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);
            Console.WriteLine("Here is what we have in common:");
            foreach (string s in carIntersect)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayUnion()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            //  合并这两个容器
            var carUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything:");
            foreach (string s in carUnion)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayConcat()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            //  合并这两个容器
            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything:");
            foreach (string s in carConcat)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayConcatNoDups()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            //  合并这两个容器
            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything:");
            foreach (string s in carConcat.Distinct())
            {
                Console.WriteLine(s);
            }
        }

        static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };

            //  不同的聚合示例
            Console.WriteLine("Max temp: {0}", (from t in winterTemps select t).Max());

            Console.WriteLine("Min temp: {0}", (from t in winterTemps select t).Min());

            Console.WriteLine("Avarage temp: {0}", (from t in winterTemps select t).Average());

            Console.WriteLine("Sum of all temps: {0}", (from t in winterTemps select t).Sum());
        }
    }
}
