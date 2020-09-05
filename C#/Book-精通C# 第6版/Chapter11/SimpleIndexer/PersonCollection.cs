using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIndexer
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        //  类的自定义索引
        public Person this[int index]
        {
            get { return (Person)arPeople[index]; }
            set { arPeople.Insert(index, value); }
        }


        //  为调用者进行转换
        public Person GetPerson(int pos)
        {
            return (Person)arPeople[pos];
        }

        //  只插入Person对象
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }

        public void ClearPeople()
        {
            arPeople.Clear();
        }

        public int Count
        {
            get { return arPeople.Count; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arPeople.GetEnumerator();
        }
    }
}
