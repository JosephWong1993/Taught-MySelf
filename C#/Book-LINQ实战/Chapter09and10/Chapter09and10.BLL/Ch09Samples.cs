using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Commom;
using Commom.SampleHarness;
using System.Xml;
using System.Xml.Linq;

namespace Chapter09and10.BLL
{
    public class Ch09Samples : SampleClass
    {
        [Sample(9, 3, "9-3：使用DOM生成XML文档")]
        public void CreatingXmlWithDOM()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement books = doc.CreateElement("books");
            XmlElement author1 = doc.CreateElement("author");
            author1.InnerText = "Fabrice Marguerie";
            XmlElement author2 = doc.CreateElement("author");
            author2.InnerText = "Steve Eichert";
            XmlElement author3 = doc.CreateElement("author");
            author3.InnerText = "Jim Wooley";
            XmlElement title = doc.CreateElement("title");
            title.InnerText = "LINQ in Action";
            XmlElement book = doc.CreateElement("book");
            book.AppendChild(author1);
            book.AppendChild(author2);
            book.AppendChild(author3);
            book.AppendChild(title);
            books.AppendChild(book);
            doc.AppendChild(books);
            Console.WriteLine(doc.OuterXml);
        }

        [Sample(9, 4, "9-4：使用LINQ to XNL生成XML文档")]
        public void CreatingXmlWithLinqToXml()
        {
            XElement doc =
                new XElement("books",
                    new XElement("book",
                        new XElement("author", "Fabrice Marguerie"),
                        new XElement("author", "Steve Eichert"),
                        new XElement("author", "Jim Wooley"),
                        new XElement("title", "LINQ in Action"),
                        new XElement("pubblisher", "Manning")));
            Console.WriteLine(doc);
        }

        [Sample(9, 6, "9-6：在DOM中操作带有命名空间的XML")]
        public void NamespacesWithDOM()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("channel.xml");

            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("dc", "http://purl.org/dc/elements/1.1/");
            ns.AddNamespace("slash", "http://purl.org/rss/1.0/modules/slash/");
            ns.AddNamespace("wfw", "http://wellformedweb.org/CommentAPI/");

            XmlNodeList commentNodes = doc.SelectNodes("//slash:comments", ns);
            foreach (XmlNode node in commentNodes)
            {
                Console.WriteLine(node.InnerText);
            }

            XmlNodeList titleNodes = doc.SelectNodes("/rss/channel/item/title");
            foreach (XmlNode node in titleNodes)
            {
                Console.WriteLine(node.InnerText);
            }
        }

        [Sample(9, 7, "9-7：在LINQ to XML中操作带有命名空间的XML")]
        public void NamespacesWithLINQtoXml()
        {
            XElement rss = XElement.Load("channel.xml");
            XNamespace dc = "http://purl.org/dc/elements/1.1/";
            XNamespace slash = "http://purl.org/rss/1.0/modules/slash/";
            XNamespace wfw = "http://wellformedweb.org/CommentAPI/";

            IEnumerable<XElement> comments = rss.Descendants(slash + "comments");
            foreach (XElement comment in comments)
            {
                Console.WriteLine(comment);
            }

            IEnumerable<XElement> titles = rss.Descendants("title");
            foreach (XElement title in titles)
            {
                Console.WriteLine((string)title);
            }
        }

        [Sample(9, 8, "9-8：从现有XmlReader中创建XElement")]
        public void LoadFromXmlReader()
        {
            using (XmlReader reader = XmlReader.Create("books.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        break;
                    }
                }
                XElement booksXml = XNode.ReadFrom(reader) as XElement;
                Console.WriteLine(booksXml);
            }
        }

        [Sample(9, 9, "9-9：使用XmlReader中的某一段XML创建XElement对象")]
        public void LoadFromXmlReader_SpecificElement()
        {
            using (XmlReader reader = XmlTextReader.Create("books.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "book")
                        break;
                }
                XElement booksXml = XNode.ReadFrom(reader) as XElement;
                Console.WriteLine(booksXml);
            }
        }

        [Sample(9, 10, "9-10：将字符串中包含的XML解析成XElement")]
        public void Parse()
        {
            XElement x = XElement.Parse(@"
<books>
    <book>
        <author>Don Box</author>
        <title>Essential .NET</title>
    </book>
    <book>
        <author>Martin Fowler</author>
        <title>Patterns of Enterprise Application Architecture</title>
    </book>
</books>");
            Console.WriteLine(x);
        }

        [Sample(9, 11, "9-11：用函数式创建生成XElement")]
        public void CreateWithFunctionalConstruction()
        {
            XElement books = new XElement("books",
                new XElement("book",
                    new XElement("author", "Don Box"),
                    new XElement("title", "Essential .NET")));
            Console.WriteLine(books);
        }

        [Sample(9, 12, "9-12：使用LINQ to XML中提供的命令式的代码结构来创建XML")]
        public void CreateWithImperative()
        {
            XElement book = new XElement("book");
            book.Add(new XElement("author", "Don Box"));
            book.Add(new XElement("title", "Essential .NET"));

            XElement books = new XElement("books");
            books.Add(book);

            Console.WriteLine(books);
        }

        [Sample(9, 13, "9-13：使用LINQ to XML创建XML树")]
        public void CreateXmlTree()
        {
            XElement books = new XElement("books",
                new XElement("book",
                    new XElement("title", "LINQ in Action"),
                    new XElement("authors",
                        new XElement("author", "Fabrice Marguerie"),
                        new XElement("author", "Steve Eichert"),
                        new XElement("author", "Jim Wooley")),
                    new XElement("publicationDate", "January 2008")),
                new XElement("book",
                    new XElement("title", "Ajax in Action"),
                    new XElement("authors",
                        new XElement("author", "Dave Crane"),
                        new XElement("author", "Eric Pascarello"),
                        new XElement("author", "Darren James")),
                    new XElement("publicationDate", "October 2005")));
        }

        [Sample(9, 15, "9-15：使用同一个XNamespace对象创建多个XElement")]
        public void UsingXNamespace()
        {
            XNamespace ns = "http://linqinaction.net";
            XElement book = new XElement(ns + "book",
                new XElement(ns + "title", "LINQ in Action"),
                new XElement(ns + "author", "Fabrice Marguerie"),
                new XElement(ns + "author", "Steve Eichert"),
                new XElement(ns + "author", "Jim Wooley"),
                new XElement(ns + "publisher", "Manning"));
            Console.WriteLine(book);
        }

        [Sample(9, 16, "9-16：将前缀与命名空间关联起来")]
        public void NamespacePrefix()
        {
            XNamespace ns = "http://linqinaction.net";
            XElement book = new XElement(ns + "book",
                new XAttribute(XNamespace.Xmlns + "l", ns));

            Console.WriteLine(book);
        }

        [Sample(9, 17, "9-17：创建带有属性的XML")]
        public void CreateWithAttribute()
        {
            XElement book = new XElement("book",
                new XAttribute("publicationDate", "Outober 2005"),
                new XElement("title", "Ajax in Action"));
            Console.WriteLine(book);
        }

        [Sample(9, 22, "9-22：使用XDocument类型以及函数式创建模式生成XML文档")]
        public void CreateDocument()
        {
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XProcessingInstruction("XML-stylesheet", "friendly-rss.xsl"),
                new XElement("rss",
                    new XElement("channel", "my channel")));
            Console.WriteLine(doc);
        }

        [Sample(9, 23, "9-23：创建带有XML样式表处理指令的XML文档")]
        public void DocumentWithXProcessingInstruction()
        {
            XDocument d = new XDocument(
                new XProcessingInstruction("XML-stylesheet", "href='http://iqueryable.com/friendly-rss.xsl' type='text/xsl' media='screen'"),
                new XElement("rss",
                    new XAttribute("version", "2.0"),
                    new XElement("channel",
                        new XElement("item", "my item"))));
            Console.WriteLine(d);
        }

        [Sample(9, 24, "9-24：使用XDocumentType创建带有文档类型声明的HTML文档")]
        public void DocumentWithXDocumentType()
        {
            XDocument html = new XDocument(
                new XDocumentType("HTML", "-//W3C//DTD HTML 4.01//EN", "http://www.w3.org/TR/html4/strict.dtd", null),
                new XElement("html",
                    new XElement("body", "This is the body!")));
            Console.WriteLine(html);
        }

        [Sample(9, 25, "9-25：使用Add方法为XElement添加内容")]
        public void AddVariableNumberOfContentItems()
        {
            XElement books = new XElement("books");
            books.Add(new XElement("book",
                new XAttribute("publicationDate", "May 2006"),
                new XElement("author", "Chris Sells"),
                new XElement("title", "Windows Forms Programming")));
            Console.WriteLine(books);
        }

        [Sample(9, 26, "9-26：使用Remove方法移除XElement的一个或多个子元素")]
        public void RemoveFirstElement()
        {
            XElement books = XElement.Load("existingBooks.xml");
            books.Element("book").Remove(); //  remove the first book
            Console.WriteLine(books);

            Console.WriteLine();

            books.Elements("book").Remove();    //  remove all books
            Console.WriteLine(books);
        }

        [Sample(9, 27, "9-27：将元素的子元素替换为新内容")]
        public void ReplaceNodesWithIEnumerableOfXElements()
        {
            XElement books = XElement.Parse(@"
<books>
    <book>
        <title>LINQ in Action</title>
        <author>Steve Eichert</author>
    </book>
</books>");
            books.Element("book").ReplaceNodes(
                new XElement("title", "Ajax in Action"),
                new XElement("author", "Dave Crane"));
            Console.WriteLine(books);
        }

        [Sample(9, 28, "9-28：使用ReplaceWith方法替换整个元素")]
        public void ReplaceWith()
        {
            XElement books = XElement.Parse(@"
<books>
    <book>
        <title>LINQ in Action</title>
        <author>Steve Eichert</author>
    </book>
</books>");
            var titles = books.Descendants("title").ToList();
            foreach (XElement title in titles)
            {
                title.ReplaceWith(new XElement("book_title", (string)title));
            }
            Console.WriteLine(books);
        }

        [Sample(9, 29, "9-29：使用Save方法将XElement保存至磁盘中")]
        public void Save()
        {
            XElement books = new XElement("books",
                new XElement("book",
                    new XElement("title", "LINQ in Action"),
                    new XElement("author", "Steve Eichert"),
                    new XElement("author", "Jim Wooley"),
                    new XElement("author", "Fabrice Marguerie")));
            books.Save(@"newBooks.XML");
            Console.WriteLine(books);
        }
    }
}
