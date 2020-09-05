using LinqBooks.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapter04.Web
{
    public partial class Partitioning : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewComplete.DataSource =
                    SampleData.Books
                    .Select((book, index) => new { Index = index, Book = book.Title }); //  显示完整的列表
                GridViewComplete.DataBind();

                int count = SampleData.Books.Count();   //  准备两个下拉框
                for (int i = 0; i < count; i++)
                {
                    ddlStart.Items.Add(i.ToString());
                    ddlEnd.Items.Add(i.ToString());
                }

                ddlStart.SelectedIndex = 2;
                ddlEnd.SelectedIndex = 3;

                DisplayPartialData();   //  显示过滤后的元素
            }
        }

        protected void DdlStart_SelectedIndexChanged(object sender, EventArgs e) => DisplayPartialData();

        private void DisplayPartialData()
        {
            int startIndex = int.Parse(ddlStart.SelectedValue); //  获取开始和结束的位置
            int endIndex = int.Parse(ddlEnd.SelectedValue);

            GridViewPartial.DataSource =    //  显示过滤后的列表
                SampleData.Books
                .Select((book, index) => new { Index = index, Book = book.Title })
                .Skip(startIndex)
                .Take(endIndex - startIndex + 1);
            GridViewPartial.DataBind();
        }
    }
}