using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public _Default()
    {
        //  显式挂接Load和Unload事件
        this.Load += Page_Load;
        this.Unload += Page_UnLoad;
        this.Error += Page_Error;
    }

    void Page_Error(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Write("I am sorry ... I can't find a required file.<br />");
        Response.Write(string.Format("The error was: <br>{0}</br>",
            Server.GetLastError().Message));
        Server.ClearError();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Load event fired!");
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //  不能再向HTTP响应输出数据，因为我们会写入本地文件
        System.IO.File.WriteAllText(@"F:\MyLog.txt", "Page unloading!");
    }

    protected void btnPostBack_Click(object sender, EventArgs e)
    {
        //  没有任何东西，只是为了进行页面回拨
    }

    protected void btnTriggerError_Click(object sender, EventArgs e)
    {
        System.IO.File.ReadAllText(@"C:\IDontExist.txt");
    }
}