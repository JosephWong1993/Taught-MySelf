using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoLotConnectedLayer;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFillData_Click(object sender, EventArgs e)
    {
        Trace.Write("CodeFileTraceInfo!", "Filling the grid!");

        InventoryDAL dal = new InventoryDAL();
        dal.OpenConnection(@"Data Source=49.235.249.194;Initial Catalog=AutoLot;Uid=sa;Pwd=xh100120763;");
        carsGridView.DataSource = dal.GetAllInventoryAsList();
        carsGridView.DataBind();
        dal.CloseConnection();
    }
}