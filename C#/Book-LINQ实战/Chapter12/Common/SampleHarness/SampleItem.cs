using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Common.SampleHarness
{
    public class SampleItem
    {
        public int Chapter { set; get; }

        public int ListingNumber { get; set; }

        public string Description { get; set; }

        public MethodInfo Method { get; set; }
    }
}
