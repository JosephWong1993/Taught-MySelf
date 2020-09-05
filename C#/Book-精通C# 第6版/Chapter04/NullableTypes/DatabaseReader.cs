using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableTypes
{
    class DatabaseReader
    {
        //可空数据字段
        public int? numericValue = null;
        public bool? boolValue = true;

        //注意可空返回类型
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }

        //注意可空返回类型
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}
