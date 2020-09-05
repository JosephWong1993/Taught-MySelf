using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerialization
{
    [Serializable]
    class MoreData
    {
        private string dataItemOne = "First data block";
        private string dataItemTwo = "More data";

        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            //  在序列号过程中就得到调用
            dataItemOne = dataItemOne.ToUpper();
            dataItemTwo = dataItemTwo.ToUpper();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            //  一旦反序列化过程结束,就得到调用
            dataItemOne = dataItemOne.ToLower();
            dataItemTwo = dataItemTwo.ToLower();
        }
    }
}
