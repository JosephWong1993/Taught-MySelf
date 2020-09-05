using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplyingAttributes
{
    //  该类可以保存到磁盘
    [Serializable]
    public class Motorcycle
    {
        //  可是这个字段不能被持久化
        [NonSerialized]
        float weightOfCurrentPassengers;

        //  这些字段要被持久化
        bool hasRadioSystem;
        bool hasHeadSet;
        bool hasSissyBar;
    }
}
