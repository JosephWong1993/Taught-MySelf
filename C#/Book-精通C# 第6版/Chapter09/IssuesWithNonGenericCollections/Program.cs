using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void SimplyBoxUnboxOperation()
        {
            //  创建一个ValueType(int)变量
            int myInt = 25;

            //  将int装箱为object引用
            object boxedInt = myInt;

            //  拆箱为错误的数据类型将触发运行时异常
            try
            {
                int unboxedInt = (int)boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WorkWithArrayList()
        {
            //  在传递给要求object的成员时,值类型将自动装箱
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);

            //  当将object转换回栈数据时,会发生拆箱
            int i = (int)myInts[0];

            //  由于WriteLine()要求object类型,因此再次发生装箱操作
            Console.WriteLine("Value of your int:{0}", i);
        }

        static void ArrayListOfRandomObject()
        {
            //  ArrayList可以保存任何类型
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
        }

        static void UsePersonCollection()
        {
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            //  这会产生编译时错误
            //  myPeople.AddPerson(new Car());

            foreach (Person p in myPeople)
            {
                Console.WriteLine(p);
            }
        }

        static void UseGenericList()
        {
            Console.WriteLine("Fun with Generics *****\n");

            //  该List<>只能容纳Person对象
            List    <Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);

            //  该List<>只能容纳整数
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];

            //  编译时错误!不能将Person对象添加到整数列表中
            //  moreInts.Add(new Person());
        }
    }
}
