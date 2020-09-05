using LinqBooks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter04.Web
{
    public partial class Step2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource =
                SampleData.Books
                .Where(b => b.Title.Length > 10)
                .OrderBy(b => b.Price);
            GridView1.DataBind();
        }
    }
}