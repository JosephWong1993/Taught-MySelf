using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ComparableCar
{
    class PetNameComparer : IComparer
    {
        int IComparer.Compare(object o1, object o2)
        {
            Car t1 = o1 as Car;
            Car t2 = o2 as Car;
            if (t1 != null && t2 != null)
            {
                return String.Compare(t1.PetName, t2.PetName);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car");
            }
        }
    }
}
