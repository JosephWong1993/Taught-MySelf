using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            UseGenericStack();
            UseGenericQueue();
            UseSortedSet();

            Console.ReadLine();
        }

        static void UseGenericList()
        {
            //  使用集合/对象初始化语法,构建一个Person对象的列表
            List<Person> people = new List<Person>()
            {
                new Person{FirstName="Homer",LastName="Simpson",Age=47},
                new Person{FirstName="Marge",LastName="Simpson",Age=45},
                new Person{FirstName="Lisa",LastName="Simpson",Age=9},
                new Person{FirstName="Bart",LastName="Simpson",Age=8}
            };

            //  打印列表中项的个数
            Console.WriteLine("Item in list:{0}", people.Count);

            //  枚举列表
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            //  插入一个新的Person
            Console.WriteLine("\n->Inserting new person");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list:{0}", people.Count);

            //  将数据复制到新的数组中
            Person[] arrayOfPeople = people.ToArray();
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine("Firest Name:{0}", arrayOfPeople[i].FirstName);
            }

            Console.WriteLine();
        }

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            //  观察栈顶的项,取出,再次观察
            Console.WriteLine("First person is:{0}", stackOfPeople.Peek());
            Console.WriteLine("Poped off {0}", stackOfPeople.Pop());

            Console.WriteLine("\nFirst person is:{0}", stackOfPeople.Peek());
            Console.WriteLine("Poped off {0}", stackOfPeople.Pop());

            Console.WriteLine("\nFirst person item is:{0}", stackOfPeople.Peek());
            Console.WriteLine("Poped off {0}", stackOfPeople.Pop());

            try
            {
                Console.WriteLine("\nFirst person is:{0}", stackOfPeople.Peek());
                Console.WriteLine("Poped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
            }

            Console.WriteLine();
        }

        static void UseGenericQueue()
        {
            //  创建一个包含3个人的队列
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            //  观察队列中的第一个人
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);

            //  移除队列中的人
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());

            //  再次从队列中获取数据
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error! {0}", e.Message);
            }
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        static void UseSortedSet()
        {
            //  添加一些不同年龄的人\
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person{FirstName="Homer",LastName="Simpson",Age=47},
                new Person{FirstName="Marge",LastName="Simpson",Age=45},
                new Person{FirstName="Lisa",LastName="Simpson",Age=9},
                new Person{FirstName="Bart",LastName="Simpson",Age=8}
            };

            //  各项是按照年龄排序的
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            //  添加一些具有不同年龄的人
            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });

            //  仍然按照年龄排序
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }
    }
}
