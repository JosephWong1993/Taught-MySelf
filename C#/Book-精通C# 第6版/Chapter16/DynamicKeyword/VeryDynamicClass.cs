using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicKeyword
{
    class VeryDynamicClass
    {
        //  动态字段
        private static dynamic myDynamicField;

        //  动态属性
        public dynamic DynamicProperty { get; set; }

        //  动态返回值类型和动态参数类型
        public dynamic DynamicMethod(dynamic dynamicParam)
        {
            //  动态本地变量
            dynamic dynamicLocalVar = "Local variable";

            int myInt = 10;
            if (dynamicParam is int)
            {
                return dynamicLocalVar;
            }
            else
            {
                return myInt;
            }
        }
    }
}
