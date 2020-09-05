using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace CustomSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Seralization *****");

            //  这个类型实现了ISerializable
            StringData myData = new StringData();

            //  以SOAP格式保存到本地文件中
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream("MyData.soap", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, myData);
            }

            MoreData moreData = new MoreData();
            using (Stream fStream = new FileStream("MoreData.soap", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, moreData);
            }
            Console.ReadLine();
        }
    }
}
