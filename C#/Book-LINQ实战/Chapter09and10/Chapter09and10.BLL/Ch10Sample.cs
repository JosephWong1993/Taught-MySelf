using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Commom.SampleHarness;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;
using Common;

namespace Chapter09and10.BLL
{
    public class Ch10Sample : SampleClass
    {
        [Sample(10, 4, "10-04：使用Element轴方法通过元素名称得到单一的元素")]
        public void Chapter10_4()
        {
            XElement root = XElement.Load("categorizedBooks.xml");
            XElement dotNetCategory = root.Element("category");
            XAttribute name = dotNetCategory.Attribute("name");

            XElement books = dotNetCategory.Element("books");
            IEnumerable<XElement> bookElements = books.Elements("book");
            Console.WriteLine(name.Value);
            foreach (var bookElement in bookElements)
            {
                Console.WriteLine(" - " + bookElement.Value);
            }
        }

        [Sample(10, 5, "10-05：使用Descendants方法返回XML中所有的book元素")]
        public void Chapter10_5()
        {
            XElement books = XElement.Load("categorizedBooks.xml");
            foreach (XElement bookElement in books.Descendants("book"))
            {
                Console.WriteLine(bookElement.Value);
            }
        }

        [Sample(10, 6, "10-06：比较Descendants和DescandantsAndSelf")]
        public void DescendantsVsSelfAndDescendants()
        {
            XElement root = XElement.Load("categorizedBooks.xml");
            IEnumerable<XElement> categories = root.Descendants("category");

            Console.WriteLine("Descendants");
            foreach (XElement categoryElement in categories)
            {
                Console.WriteLine(" - " + categoryElement.Attribute("name").Value);
            }

            categories = root.DescendantsAndSelf("category");
            Console.WriteLine("DescendantsAndSelf");
            foreach (XElement categoryElement in categories)
            {
                Console.WriteLine(" - " + categoryElement.Attribute("name").Value);
            }
        }

        [Sample(10, 7, "10-07：使用LINQ查询表达式语法来查询XML")]
        public void DescendantsWithQueryExpressions()
        {
            XElement root = XElement.Load("categorizedBooks.xml");
            var books = from book in root.Descendants("book")
                        select book.Value;

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }

        [Sample(10, 8, "10-08：使用Ancestors方法查询XML以获取某元素的父元素")]
        public void Ancestor()
        {
            XElement root = XElement.Load("categorizedBooks.xml");
            XElement dddBook = root.Descendants("book")
                .Where(book => book.Value == "Domain Driven Design")
                .First();

            IEnumerable<XElement> ancestors = dddBook.Ancestors("category").Reverse();  //  反序操作，因为需要得到自顶向下的输出格式

            string categoryPath = String.Join("/", ancestors.Select(e => e.Attribute("name").Value).ToArray());
            Console.WriteLine(dddBook.Value + "is in the：" + categoryPath + " category.");
        }

        [Sample(10, 9, "10-09：使用ElementsBeforeSelf得到某元素同一层次之前的节点")]
        public void ElementsBeforeSelf()
        {
            XElement root = XElement.Load("categorizedBooks.xml");
            XElement dddBook = root.Descendants("book")
                .Where(book => book.Value == "Domain Driven Design")
                .First();

            IEnumerable<XElement> beforeSelf = dddBook.ElementsBeforeSelf();
            foreach (XElement element in beforeSelf)
            {
                Console.WriteLine(element.Value);
            }
        }

        [Sample(10, 21, "10-21：使用XPath查询XElement对象")]
        public void XPathSelectElements()
        {
            XElement root = XElement.Load("categorizedBooks.xml");
            var books = from book in root.XPathSelectElements("//book")
                        select book;
            foreach (XElement book in books)
            {
                Console.WriteLine(book.Value);
            }
        }

        [Sample(10, 24, "10-24：从XML中获取每本书的标题，出版商和作者")]
        public void Chapter10_24()
        {
            XElement booksXml = XElement.Load("books.xml");
            var books = from book in booksXml.Descendants("book")
                        select new
                        {
                            Title = book.Element("title"),
                            Publisher = book.Element("publisher"),
                            Authors = String.Join(",", book.Descendants("author").Select(a => a.Value).ToArray())
                        };
            foreach (var book in books)
            {
                Console.WriteLine(book.Title.Value);
                Console.WriteLine(book.Publisher.Value);
                Console.WriteLine(book.Authors);
                Console.WriteLine();
            }
        }

        [Sample(10, 25, "10-25：从XML中获取每本书的标题，出版商和作者")]
        public void Transformation()
        {
            XElement booksXml = XElement.Load("books.xml");
            var books = from book in booksXml.Descendants("book")
                        select new
                        {
                            Title = book.Element("title"),
                            Publisher = book.Element("publisher"),
                            Authors = String.Join(",", book.Descendants("author").Select(a => a.Value).ToArray())
                        };
            XElement html = new XElement("html",
                new XElement("body",
                    new XElement("h1", "LINQ Books Library"),
                    from book in booksXml.Descendants("book")
                    select new XElement("div",
                        new XElement("b", book.Element("title").Value),
                            "By：" + String.Join(", ", book.Descendants("author").Select(b => b.Value).ToArray()) +
                            "Published By：" + book.Element("publisher"))));
            Console.WriteLine(html);
        }

        [Sample(10, 26, "10-26：使用XSLT转换XElement")]
        public void TransformationWithXSLT()
        {
            string xsl = @"<?xml version='1.0' encoding='UTF-8' ?>
                            <xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
	                            <xsl:template match='books'>
		                            <html>
			                            <title>Book Catalog</title>
			                            <ul>
				                            <xsl:apply-templates select='book'/>
			                            </ul>
		                            </html>
	                            </xsl:template>
	                            <xsl:template match='book'>
		                            <li>
			                            <xsl:value-of select='title'/> by <xsl:apply-templates select='author'/>
		                            </li>
	                            </xsl:template>
	                            <xsl:template match='author'>
		                            <xsl:if test='position() > 1'>, </xsl:if>
		                            <xsl:value-of select='.'/>
	                            </xsl:template>
                            </xsl:stylesheet>";
            XElement books = XElement.Load("books.xml");
            XDocument output = new XDocument();
            using (XmlWriter writer = output.CreateWriter())
            {
                XslCompiledTransform xslTransformer = new XslCompiledTransform();
                xslTransformer.Load(XmlReader.Create(new StringReader(xsl)));
                xslTransformer.Transform(books.CreateReader(), writer);
            }
            Console.WriteLine(output);
        }

        [Sample(10, 27, "10-27：通过Xsl转换XNode的扩展方法")]
        public void Chapter10_27()
        {
            string xsl = @"<?xml version='1.0' encoding='UTF-8' ?>
                            <xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
	                            <xsl:template match='books'>
		                            <html>
			                            <title>Book Catalog</title>
			                            <ul>
				                            <xsl:apply-templates select='book'/>
			                            </ul>
		                            </html>
	                            </xsl:template>
	                            <xsl:template match='book'>
		                            <li>
			                            <xsl:value-of select='title'/> by <xsl:apply-templates select='author'/>
		                            </li>
	                            </xsl:template>
	                            <xsl:template match='author'>
		                            <xsl:if test='position() > 1'>, </xsl:if>
		                            <xsl:value-of select='.'/>
	                            </xsl:template>
                            </xsl:stylesheet>";
            XDocument output = XElement.Load("books.xml").XslTransform(xsl);
            Console.WriteLine(output);
        }
    }
}
