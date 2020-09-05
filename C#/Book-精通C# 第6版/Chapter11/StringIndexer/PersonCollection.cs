using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringIndexer
{
    class PersonCollection : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        //  这个索引器基于一个字符串索引返回一个Person
        public Person this[string name]
        {
            get { return listPeople[name]; }
            set { listPeople[name] = value; }
        }

        public void ClearPeople()
        {
            listPeople.Clear();
        }

        public int Count
        {
            get { return listPeople.Count; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listPeople.GetEnumerator();
        }
    }
}
