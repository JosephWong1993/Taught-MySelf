using LinqBooks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter04.Web
{
    public partial class Joins : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  组连接
            //GridView1.DataSource =
            //    from publisher in SampleData.Publishers
            //    join book in SampleData.Books on publisher equals book.Publisher into publisherBooks
            //    select new
            //    {
            //        Publisher = publisher.Name,
            //        Books = publisherBooks
            //    };

            //  内连接
            //GridView1.DataSource =
            //    from publisher in SampleData.Publishers
            //    join book in SampleData.Books on publisher equals book.Publisher
            //    select new { Publisher = publisher.Name, Book = book.Title };
            //GridView1.DataSource =
            //    SampleData.Publishers
            //    .Join(SampleData.Books, //  内部序列
            //        publisher => publisher, //  外部的Key选择器
            //        book => book.Publisher, //  内部的Key选择器
            //        (publieher, book) => new    //  结果选择器
            //        {
            //            Publisher = publieher.Name,
            //            Book = book.Title
            //        });

            //  左外连接
            //GridView1.DataSource = from publisher in SampleData.Publishers
            //                       join book in SampleData.Books on publisher equals book.Publisher into publisherBooks
            //                       from book in publisherBooks.DefaultIfEmpty()
            //                       select new
            //                       {
            //                           Publisher = publisher.Name,
            //                           Book = book == default(Book) ? "(no books)" : book.Title
            //                       };

            GridView1.DataSource = from publisher in SampleData.Publishers
                                   from book in SampleData.Books
                                   select new
                                   {
                                       Correct = (publisher == book.Publisher),
                                       Publisher = publisher.Name,
                                       Book = book.Title
                                   };

            GridView1.DataBind();
        }
    }
}