using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LinqToXmlWinApp
{
  class LinqToXmlObjectModel
  {
    public static XDocument GetXmlInventory()
    {
      try
      {
        XDocument inventoryDoc = XDocument.Load("Inventory.xml");
        return inventoryDoc;
      }
      catch (System.IO.FileNotFoundException ex)
      {
        MessageBox.Show(ex.Message);
        return null;
      }
    }

    public static void InsertNewElement(string make, string color, string petName)
    {
      //  加载当前文档
      XDocument inventoryDoc = XDocument.Load("Inventory.xml");

      //  为ID生成一个随机数
      Random r = new Random();

      //  根据传入参数新建XElement
      XElement newElement =
        new XElement("Car", new XAttribute("ID", r.Next(50000)),
          new XElement("Color", color),
          new XElement("Make", make),
          new XElement("PetName", petName));

      //  添加到内存中的对象
      inventoryDoc.Descendants("Inventory").First().Add(newElement);

      //  保存到磁盘
      inventoryDoc.Save("Inventory.xml");
    }

    public static void LookUpColorsForMake(string make)
    {
      //  加载当前文档
      XDocument inventoryDoc = XDocument.Load("Inventory.xml");

      //  根据给定的值查找颜色
      var makeInfo = from car in inventoryDoc.Descendants("Car")
                     where car.Element("Make").Value == make
                     select car.Element("Color").Value;

      //  构建一个代表每个颜色的字符串
      string data = string.Empty;
      foreach (var item in makeInfo.Distinct())
      {
        data += string.Format("- {0}\n", item);
      }

      //  显示颜色
      MessageBox.Show(data, string.Format("{0} colors:", make));
    }
  }
}
