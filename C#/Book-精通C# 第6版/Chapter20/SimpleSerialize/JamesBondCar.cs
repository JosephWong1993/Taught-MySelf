using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SimpleSerialize
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.MyCompany.com")]
    public class JamesBondCar : Car
    {
        public JamesBondCar(bool skyWorthy, bool seaWorthy)
        {
            canFly = skyWorthy;
            canSubmerge = seaWorthy;
        }
        //  XmlSerializer需要一个默认的构造函数
        public JamesBondCar()
        {

        }

        [XmlAttribute]
        public bool canFly;
        [XmlAttribute]
        public bool canSubmerge;
    }
}
