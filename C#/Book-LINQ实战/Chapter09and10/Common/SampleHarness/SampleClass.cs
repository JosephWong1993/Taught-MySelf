using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace Commom.SampleHarness
{
    public class SampleClass : IEnumerable<SampleItem>
    {
        string _Title;
        public string Title { get { return _Title; } }

        StreamWriter _OutputStreamWriter;
        public StreamWriter OutputStreamWriter
        {
            get { return _OutputStreamWriter; }
        }

        List<SampleItem> _MethodList;
        public SampleItem this[int index]
        {
            get
            {
                return this._MethodList[index];
            }
        }

        public SampleClass()
        {
            _OutputStreamWriter = new StreamWriter(new MemoryStream());

            Type ClassType = base.GetType();
            this._Title = ClassType.Name;
            var items =
                from MethodInfo _method in ClassType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                from SampleAttribute _attrib in _method.GetCustomAttributes(false).OfType<SampleAttribute>()
                select new SampleItem()
                {
                    Chapter = _attrib.Chapter,
                    ListingNumber = _attrib.ListingNumber,
                    Description = _attrib.Description,
                    Method = _method,
                };
            _MethodList = new List<SampleItem>();
            _MethodList.AddRange(items);
        }

        public IEnumerator<SampleItem> GetEnumerator()
        {
            return _MethodList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _MethodList.GetEnumerator();
        }
    }
}
