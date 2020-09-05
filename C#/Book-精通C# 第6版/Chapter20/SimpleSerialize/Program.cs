using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
//  获取对mscorlib.dll中的BinaryFormatter的访问
using System.Runtime.Serialization.Formatters.Binary;
//  必须引用System.Runtime.Serialization.Formatters.Soap.dll
using System.Runtime.Serialization.Formatters.Soap;
//  定义在System.Xml.Serialization
using System.Xml.Serialization;

namespace SimpleSerialize
{
    class Program
    {
        //  确保使用了System.Runtime.Serializatiom.Formatters.Binary和System.IO命名空间
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Serialization *****\n");

            //  建立一个JamesBondCar并设定状态
            JamesBondCar jbc = new JamesBondCar();
            jbc.canFly = true;
            jbc.canSubmerge = false;
            jbc.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
            jbc.theRadio.hasTweeters = true;

            //  将car以二进制歌手保存到指定文件中
            SavaAsBinaryFormat(jbc, "CarData.dat");
            LaodFromBinaryFile("CarData.dat");

            SaveAsSoapFormat(jbc, "CarData.soap");
            SaveAsXmlFormat(jbc, "CarData.xml");
            SaveListOfCars();
            SaveListOfCarsAsBinary();
            Console.ReadLine();
        }

        static void SerializeObjectGraph(IFormatter itfFormat, Stream destStream, object graph)
        {
            itfFormat.Serialize(destStream, graph);
        }

        private static void SavaAsBinaryFormat(JamesBondCar objGraph, string fileName)
        {
            //  将对象以二进制保存到一个名为CarData.dat的文件中
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Save car in binary format!");
        }

        static void LaodFromBinaryFile(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            //  从二进制文件中读取JamesBondCar对象
            using (Stream fStream = File.OpenRead(fileName))
            {
                JamesBondCar carFromDisk = (JamesBondCar)binFormat.Deserialize(fStream);
                Console.WriteLine("Can this car fly?: {0}", carFromDisk.canFly);
            }
        }

        //  确保使用了System.Runtime.Serialization.Formatters.Soap
        //  并引用了System.Runtime.Serialization.Formatters.Soap.dll
        static void SaveAsSoapFormat(object objGraph, string fileName)
        {
            //  将对象以SOAP格式保存到一个名为CarData.soap的文件中
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Save car in SOAP format!");
        }

        static void SaveAsXmlFormat(object objGraph, string fileName)
        {
            //  将对象以XML格式保存到一个名为CarData.xml的文件中
            XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar));
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Save car in XML format!");
        }

        static void SaveListOfCars()
        {
            //  现在持久化一个JamesBondCar的List<T>
            List<JamesBondCar> myCars = new List<JamesBondCar>();
            myCars.Add(new JamesBondCar(true, true));
            myCars.Add(new JamesBondCar(true, false));
            myCars.Add(new JamesBondCar(false, true));
            myCars.Add(new JamesBondCar(false, false));

            using (Stream fStream = new FileStream("CarCollection.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<JamesBondCar>));
                xmlFormat.Serialize(fStream, myCars);
            }
            Console.WriteLine("=> Saved List of cars!");
        }

        static void SaveListOfCarsAsBinary()
        {
            //  将ArrayList对象(myCars)保存为二进制
            List<JamesBondCar> myCars = new List<JamesBondCar>();
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("AllMyCars.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, myCars);
            }
            Console.WriteLine("=> Saved List of cars in binary!");
        }
    }
}
