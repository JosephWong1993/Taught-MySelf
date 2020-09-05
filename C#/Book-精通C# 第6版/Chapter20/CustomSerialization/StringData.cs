using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerialization
{
    [Serializable]
    class StringData : ISerializable
    {
        private string dataItemOne = "First data block";
        private string dataItemTwo = "More data";

        public StringData() { }
        protected StringData(SerializationInfo si, StreamingContext ctx)
        {
            //  从流中得到合并的成员变量
            dataItemOne = si.GetString("First_Item").ToLower();
            dataItemTwo = si.GetString("dataItemTwo").ToLower();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //  用格式化数据填充SerializationInfo对象
            info.AddValue("First_Item", dataItemOne.ToUpper());
            info.AddValue("dataItemTwo", dataItemTwo.ToUpper());
        }
    }
}
