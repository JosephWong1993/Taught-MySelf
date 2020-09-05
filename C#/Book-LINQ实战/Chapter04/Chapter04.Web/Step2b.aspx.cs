using LinqBooks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter04.Web
{
    public partial class Step2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.DataSource =
            //    from book in SampleData.Books
            //    where book.Title.Length > 10
            //    orderby book.Price
            //    select new { book.Title, book.Price };
            GridView1.DataSource =
                SampleData.Books
                .Where(b => b.Title.Length > 10)
                .OrderBy(b => b.Price)
                .Select(b => new { b.Title, b.Price });
            GridView1.DataBind();
        }
    }
}