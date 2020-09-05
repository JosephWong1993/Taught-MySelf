using LinqBooks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter04.Web
{
    public partial class Sorting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var query = from book in SampleData.Books
            //            orderby book.Publisher.Name, book.Price descending, book.Title
            //            select new
            //            {
            //                Publisher = book.Publisher.Name,
            //                book.Price,
            //                book.Title
            //            };

            var query =
                SampleData.Books
                .OrderBy(book => book.Publisher.Name)
                .ThenByDescending(book => book.Price)
                .ThenBy(book => book.Title)
                .Select(book => new
                {
                    Publisher = book.Publisher.Name,
                    book.Price,
                    book.Title
                });

            this.GeidView1.DataSource = query;
            this.GeidView1.DataBind();
        }
    }
}