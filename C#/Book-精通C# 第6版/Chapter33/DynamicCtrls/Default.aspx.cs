using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private void ListControlsInPanel()
    {
        string theInfo = "";
        theInfo = string.Format("<b>Dose the panel have controls? {0}</b><br />",
            myPanel.HasControls());

        //  获取面板中的所有控件
        foreach (Control c in myPanel.Controls)
        {
            if (!object.ReferenceEquals(c.GetType(), typeof(System.Web.UI.LiteralControl)))
            {
                theInfo += "****************<br />";
                theInfo += string.Format("Control Name? {0} <br />", c.ToString());
                theInfo += string.Format("ID? {0} <br />", c.ID);
                theInfo += string.Format("Control Visible? {0} <br />", c.Visible);
                theInfo += string.Format("ViewState? {0} <br />", c.EnableViewState);
            }
        }
        lblControlInfo.Text = theInfo;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ListControlsInPanel();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnClearPanel_Click(object sender, EventArgs e)
    {
        //  清除面板中的所有内容，然后重新列出所有项
        myPanel.Controls.Clear();
        ListControlsInPanel();
    }

    protected void btnAddWidgets_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < 3; i++)
        {
            //  分配一个名字，这样随后我们就能够使用传入的表单数据获得文本值
            TextBox t = new TextBox();
            t.ID = string.Format("newTextBox{0}", i);
            myPanel.Controls.Add(t);
            ListControlsInPanel();
        }
    }

    protected void btnGetTextData_Click(object sender, EventArgs e)
    {
        //string textBoxValues = "";
        //for (int i = 0; i < Request.Form.Count; i++)
        //{
        //    textBoxValues += string.Format("<li>{0}</li><br />", Request.Form[i]);
        //}
        //lblTextBoxData.Text = textBoxValues;

        //  通过名称获取各文本框
        string labelData = string.Format("<li>{0}</li><br />",
            Request.Form.Get("newTextBox0"));
        labelData += string.Format("<li>{0}</li><br />",
            Request.Form.Get("newTextBox1"));
        labelData += string.Format("<li>{0}</li><br />",
            Request.Form.Get("newTextBox2"));
        lblTextBoxData.Text = labelData;
    }
}