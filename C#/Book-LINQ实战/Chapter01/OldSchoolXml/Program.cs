using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace OldSchoolXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]{  //  图书集合
                new Book("Ajax in Action","Manning",2005),
                new Book("Windows Forms in Action","Manning",2006),
                new Book("RSS and Atom in Action","Manning",2006)
            };

            XmlDocument doc = new XmlDocument();    //  基于集合创建XML片段
            XmlElement root = doc.CreateElement("books");
            foreach (Book book in books)
            {
                if (book.Year == 2006)
                {
                    XmlElement element = doc.CreateElement("book");
                    element.SetAttribute("title", book.Title);

                    XmlElement publisher = doc.CreateElement("publisher");
                    publisher.InnerText = book.Publisher;
                    element.AppendChild(publisher);

                    root.AppendChild(element);
                }
            }

            doc.AppendChild(root);

            doc.Save(Console.Out);  //  显示结果

            Console.ReadKey();
        }
    }
}
