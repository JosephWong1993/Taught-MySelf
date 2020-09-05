using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithLinqExpressions
{
    class ProductInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberInStock { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0},Description={1},Number in Stock={2}", Name, Description, NumberInStock);
        }
    }
}
