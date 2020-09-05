using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LinqToXmlFirstLook
{
  class Program
  {
    static void Main(string[] args)
    {
      BuildXmlDocWithDOM();

      BuildXmlDocWithLINQToXml();

      DeleteNodeForDoc();

      Console.ReadLine();
    }

    private static void BuildXmlDocWithDOM()
    {
      //  在内存中新建一个Xml文档
      XmlDocument doc = new XmlDocument();

      //  用根元素<Inventory>填充文档
      XmlElement inventory = doc.CreateElement("Inventory");

      //  现在创建一个<Car>元素,它包含一个ID特性
      XmlElement car = doc.CreateElement("Car");
      car.SetAttribute("ID", "1000");

      //  创建<Car>元素中的数据
      XmlElement name = doc.CreateElement("PetName");
      name.InnerText = "Jimbo";
      XmlElement color = doc.CreateElement("Color");
      color.InnerText = "Red";
      XmlElement make = doc.CreateElement("Make");
      make.InnerText = "Ford";

      //  将<PetName>,<Color>,<Make>添加到<Car>元素
      car.AppendChild(name);
      car.AppendChild(color);
      car.AppendChild(make);

      //  将<Car>元素添加到<Inventory>元素
      inventory.AppendChild(car);

      //  将完整的XML插入到XmlDocument对象并保存文件
      doc.AppendChild(inventory);
      doc.Save("Inventory.xml");
    }

    private static void BuildXmlDocWithLINQToXml()
    {
      //  使用更加函数式的方式创建XML文档
      XElement doc =
        new XElement("Inventory",
          new XElement("Car", new XAttribute("ID", "1000"),
            new XElement("PetName", "Jimbo"),
            new XElement("Color", "Red"),
            new XElement("Make", "Ford")
          )
        );
      //  保存到文件
      doc.Save("InventoryWithLINQ.xml");
    }

    private static void DeleteNodeForDoc()
    {
      XElement doc =
        new XElement("Inventory",
          new XElement("Car", new XAttribute("ID", "1000"),
            new XElement("PetName", "Jimbo"),
            new XElement("Color", "Red"),
            new XElement("Make", "Ford")
          )
        );

      //  从树中删除PetName元素
      doc.Descendants("PetName").Remove();
      Console.WriteLine(doc);
    }
  }
}
