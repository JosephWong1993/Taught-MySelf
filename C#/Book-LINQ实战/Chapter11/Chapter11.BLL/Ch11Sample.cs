using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Common.SampleHarness;
using System.Xml;
using System.Xml.Linq;

namespace Chapter11.BLL
{
    public class Ch11Sample : SampleClass
    {
        [Sample(11, 02, "11-02：使用对象初始化器根据XML创建Book对象")]
        public void Chapter11_02()
        {
            XElement booksXml = XElement.Load("books.xml");
            var books = from bookElement in booksXml.Elements("book")
                        select new Book
                        {
                            Title = bookElement.Element("title").Value,
                            PubDate = Convert.ToDateTime(bookElement.Element("publicationDate").Value),
                            Price = Convert.ToDecimal(bookElement.Element("Price")),
                            Isbn = bookElement.Element("isbn").Value,
                            Notes = bookElement.Element("notes").Value,
                            Summary = bookElement.Element("summary").Value
                        };
            ObjectDumper.Write(books);
        }

        [Sample(11, 03, "11-03：根据XML创建对象")]
        public void Chapter11_03()
        {
            XElement booksXml = XElement.Load("books.xml"); //  读取XML文档
            var books = from bookElement in booksXml.Elements("book")   //  使用查询表达式和对象初始化器来创建对象
                        select new Book
                        {
                            Title = bookElement.Element("title").Value,
                            Publisher1 = new Publisher
                            {
                                Name = (string)bookElement.Element("publisher")
                            },
                            PubDate = (DateTime)bookElement.Element("publicationDate"),
                            Price = (decimal)bookElement.Element("price"),
                            Isbn = (string)bookElement.Element("isbn"),
                            Notes = (string)bookElement.Element("notes"),
                            Summary = (string)bookElement.Element("summary"),
                            Authors = from authorElement in bookElement.Descendants("author")
                                      select new Author
                                      {
                                          FirstName = (string)authorElement.Element("firstName"),
                                          LastName = (string)authorElement.Element("lastName")
                                      },
                            Reviews = from reviewElement in bookElement.Descendants("review")
                                      select new Review
                                      {
                                          User1 = new User
                                          {
                                              Name = (string)reviewElement.Element("user"),
                                          },
                                          Rating = (int)reviewElement.Element("rating"),
                                          Comments = (string)reviewElement.Element("comments"),
                                      },
                        };
            ObjectDumper.Write(books);
        }

        [Sample(11, 11, "11-11：创建完整XML树的代码")]
        public void Chapter11_11()
        {
            LiaDataContext ctx = new LiaDataContext();
            XElement xml = new XElement("books",
                from book in ctx.Book
                orderby book.Title
                select new XElement("book",
                    new XElement("title", book.Title),
                    new XElement("authors",
                        from bookAuthor in book.BookAuthor
                        orderby bookAuthor.AuthorOrder
                        select new XElement("author",
                            new XElement("firstName", bookAuthor.Author1.FirstName),
                            new XElement("lastName", bookAuthor.Author1.LastName),
                            new XElement("website", bookAuthor.Author1.WebSite)
                        )
                    ),
                    new XElement("subject",
                        new XElement("name", book.Subject1.Name),
                        new XElement("description", book.Subject1.Description)
                    ),
                    new XElement("publisher", book.Publisher1.Name),
                    new XElement("publicationDate", book.Publisher1.Name),
                    new XElement("price", book.Price),
                    new XElement("isbn", book.Isbn),
                    new XElement("notes", book.Notes),
                    new XElement("summary", book.Summary),
                    new XElement("reviews",
                        from review in book.Review
                        orderby review.Rating
                        select new XElement("review",
                            new XElement("user", review.User1.Name),
                            new XElement("rating", review.Rating),
                            new XElement("comments", review.Comments)
                        )
                    )));
            ObjectDumper.Write(xml.ToString()); //  将XML输出至控制台
        }
    }
}
