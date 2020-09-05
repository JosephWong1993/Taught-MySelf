using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace HelloLinqToXml
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

            XElement xml = new XElement("books",    //  基于集合创建XML片段
                from book in books
                where book.Year == 2006
                select new XElement("book",
                    new XAttribute("title", book.Title),
                    new XElement("publisher", book.Publisher)
                )
            );

            Console.WriteLine(xml); //  输出至控制台

            Console.ReadLine();
        }
    }
}
