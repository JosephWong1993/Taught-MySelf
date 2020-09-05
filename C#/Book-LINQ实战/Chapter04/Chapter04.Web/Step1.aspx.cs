using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter04.Web
{
    public partial class Step1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String[] books = { "Funny Stories",
                "All your base are belong to us","LINQ rules",
                "C# on Rails","Bonjour mom Amour"};

            //GridView1.DataSource =
            //    from book in books
            //    where book.Length > 10
            //    orderby book
            //    select book.ToUpper();
            GridView1.DataSource = books
                .Where<string>(s => s.Length > 10)
                .OrderBy<string, string>(s => s)
                .Select<string, string>(s => s.ToUpper());
            GridView1.DataBind();
        }
    }
}
