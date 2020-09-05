using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Commom.SampleHarness
{
    public class SampleItem
    {
        public int Chapter { get; set; }

        public int ListingNumber { get; set; }

        public string Description { get; set; }

        public MethodInfo Method { get; set; }
    }
}
