//  首先列出using语句
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//  现在列出所有程序集/模块级别特性
//  强制所有在程序集中的公共类型符合CLS
[assembly: CLSCompliant(true)]

namespace AttributedCarLibrary
{
    //  使用named property(命名属性)为description赋值
    [Serializable]
    [VehicleDescription(Description = "My rocking Harley")]
    //  这次,我们使用AttributeUsage特性来注释我们的自定义特性
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    public sealed class VehicleDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public VehicleDescriptionAttribute(string vehicalDescription)
        {
            Description = vehicalDescription;
        }
        public VehicleDescriptionAttribute()
        {

        }
    }
}
