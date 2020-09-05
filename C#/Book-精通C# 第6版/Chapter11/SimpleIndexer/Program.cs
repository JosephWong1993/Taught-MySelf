using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Indexers *****\n");

            PersonCollection myPeople = new PersonCollection();

            //  使用索引器语法添加对象
            myPeople[0] = new Person("Homer", "Simpson", 40);
            myPeople[1] = new Person("Marge", "Simpson", 38);
            myPeople[2] = new Person("Lisa", "Simpson", 9);
            myPeople[3] = new Person("Bart", "Simpson", 7);
            myPeople[4] = new Person("Maggie", "Simpson", 2);

            //  现在使用索引器获取并显示每个子项
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }

            Console.WriteLine();

            UseGenericListOfPeople();

            Console.ReadLine();
        }

        static void UseGenericListOfPeople()
        {
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("Lisa", "Simpson", 9));
            myPeople.Add(new Person("Bart", "Simpson", 7));

            //  使用索引器改变第一个ren
            myPeople[0] = new Person("Maggie", "Simpson", 2);

            //  通过索引器获取和显示每一项
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }
        }
    }
}
