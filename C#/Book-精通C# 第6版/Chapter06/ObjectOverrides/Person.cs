using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        public override string ToString()
        {
            string myState;
            myState = string.Format("[FirstName:{0};LastName:{1};Age:{2}]",
                FirstName, LastName, Age);
            return myState;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return obj.ToString() == this.ToString();

            //if (obj is Person && obj != null)
            //{
            //    Person temp = (Person)obj;
            //    if (temp.FirstName == this.FirstName
            //        && temp.LastName == this.LastName
            //        && temp.Age == this.Age)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
