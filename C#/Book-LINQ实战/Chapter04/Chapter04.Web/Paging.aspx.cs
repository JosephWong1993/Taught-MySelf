using LinqBooks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter04.Web
{
    public partial class Paging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindData();
        }

        private void BindData()
        {
            GridView1.DataSource =
                SampleData.Books
                .Select(book => book.Title).ToList();
            GridView1.DataBind();
        }
    }
}