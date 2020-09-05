using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace Common.SampleHarness
{
    public class SampleClass : IEnumerable<SampleItem>
    {
        private string _Title;
        public string Title { get { return _Title; } }

        StreamWriter _OutputStreamWriter;
        public StreamWriter OutputStreamWriter { get { return _OutputStreamWriter; } }

        private List<SampleItem> _MethodsList;
        public List<SampleItem> this[int index] { get { return _MethodsList; } }

        public SampleClass()
        {
            _OutputStreamWriter = new StreamWriter(new MemoryStream());

            Type ClassType = base.GetType();
            _Title = ClassType.Name;

            var items = from MethodInfo _method in ClassType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                        from SampleAttribute _attribute in _method.GetCustomAttributes(false).OfType<SampleAttribute>()
                        select new SampleItem()
                        {
                            Chapter = _attribute.Chapter,
                            ListingNumber = _attribute.ListingNumber,
                            Description = _attribute.Description,
                            Method = _method,
                        };
            _MethodsList = items.ToList();
        }

        IEnumerator<SampleItem> IEnumerable<SampleItem>.GetEnumerator()
        {
            return _MethodsList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _MethodsList.GetEnumerator();
        }
    }
}
