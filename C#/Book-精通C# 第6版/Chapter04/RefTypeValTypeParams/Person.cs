using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefTypeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;

        //构造函数
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Person() { }

        public void Display()
        {
            Console.WriteLine("Name:{0},Age:{1}", personName, personAge);
        }
    }
}
