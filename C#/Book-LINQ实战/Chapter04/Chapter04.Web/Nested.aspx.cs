using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinqBooks.Common;

namespace Chapter04.Web
{
    public partial class Nested : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.DataSource = from publisher in SampleData.Publishers
            //                       orderby publisher.Name
            //                       select new
            //                       {
            //                           Publisher = publisher.Name,
            //                           Books = from book in SampleData.Books
            //                                   where book.Publisher == publisher
            //                                   select book
            //                       };
            GridView1.DataSource =
                from book in SampleData.Books
                group book by book.Publisher into publisgerBooks
                select new
                {
                    Publisher = publisgerBooks.Key.Name,
                    Books = publisgerBooks
                };
            GridView1.DataBind();
        }
    }
}