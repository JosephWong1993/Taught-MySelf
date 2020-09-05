using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MultitabledDataSet
{
  public partial class MainForm : Form
  {
    //  窗体级别的DataSet
    private DataSet autoLotDS = new DataSet("AutoLot");

    //  使用命令构建器来简化数据适配器的配置
    private SqlCommandBuilder sqlCBInventory;
    private SqlCommandBuilder sqlCBCustomers;
    private SqlCommandBuilder sqlCBOrders;

    //  我们的数据适配器(对于每个表)
    private SqlDataAdapter invTableAdapter;
    private SqlDataAdapter custTableAdapter;
    private SqlDataAdapter ordersTableAdapter;

    //   窗体级别的连接字符串
    private string cnStr = string.Empty;

    public MainForm()
    {
      InitializeComponent();

      //  从*.config文件中提取连接字符串
      cnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

      //  建立数据适配器
      invTableAdapter = new SqlDataAdapter("Select * from Inventory", cnStr);
      custTableAdapter = new SqlDataAdapter("Select * from Customers", cnStr);
      ordersTableAdapter = new SqlDataAdapter("Select * from Orders", cnStr);

      //  自动生成命令
      sqlCBInventory = new SqlCommandBuilder(invTableAdapter);
      sqlCBCustomers = new SqlCommandBuilder(custTableAdapter);
      sqlCBOrders = new SqlCommandBuilder(ordersTableAdapter);

      //  在DS中填充表
      invTableAdapter.Fill(autoLotDS, "Inventory");
      custTableAdapter.Fill(autoLotDS, "Customers");
      ordersTableAdapter.Fill(autoLotDS, "Orders");

      //  为表间建立关系
      BuildTableRelationship();

      //  绑定到网络
      dataGridViewInventory.DataSource = autoLotDS.Tables["Inventory"];
      dataGridViewCustomers.DataSource = autoLotDS.Tables["Customers"];
      dataGridViewOrders.DataSource = autoLotDS.Tables["Orders"];
    }

    private void BuildTableRelationship()
    {
      //  建立CustomerOrder数据关系对象
      DataRelation dr = new DataRelation("CustomerOrder",
        autoLotDS.Tables["Customers"].Columns["CustID"],
        autoLotDS.Tables["Orders"].Columns["CustID"]);
      autoLotDS.Relations.Add(dr);

      //  建立InventoryOrder数据关系对象
      dr = new DataRelation("InventoryOrder",
        autoLotDS.Tables["Inventory"].Columns["CarID"],
        autoLotDS.Tables["Orders"].Columns["CarID"]);
      autoLotDS.Relations.Add(dr);
    }

    private void BtnUpdateDatabase_Click(object sender, EventArgs e)
    {
      try
      {
        invTableAdapter.Update(autoLotDS, "Inventory");
        custTableAdapter.Update(autoLotDS, "Customers");
        ordersTableAdapter.Update(autoLotDS, "Orders");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void BtnGetOrderInfo_Click(object sender, EventArgs e)
    {
      string strOrderInfo = string.Empty;
      DataRow[] drsCust = null;
      DataRow[] drsOrder = null;

      //  从文本框得到客户的ID
      int custID = int.Parse(this.txtCustID.Text);

      //  根据custID从Customers表得到相应行
      drsCust = autoLotDS.Tables["Customers"].Select(
        string.Format("CustID = {0}", custID));
      strOrderInfo += string.Format("Customer {0}: {1} {2}\n",
        drsCust[0]["CustID"].ToString(),
        drsCust[0]["FirstName"].ToString(),
        drsCust[0]["LastName"].ToString());

      //  从Customers表切换到Orders表
      drsOrder = drsCust[0].GetChildRows(autoLotDS.Relations["CustomerOrder"]);

      //  为该客户循环所有订单
      foreach (DataRow order in drsOrder)
      {
        strOrderInfo += string.Format("----\nOrder Number:{0}\n", order["OrderID"]);

        //  通过该订单的到Car的引用
        DataRow[] drsInv = order.GetParentRows(autoLotDS.Relations["InventoryOrder"]);

        //  得到该订单中的(单个)Car信息
        DataRow car = drsInv[0];
        strOrderInfo += string.Format("Make: {0}\n", car["Make"]);
        strOrderInfo += string.Format("Color: {0}\n", car["Color"]);
        strOrderInfo += string.Format("Pet Name: {0}\n", car["PetName"]);
      }

      MessageBox.Show(strOrderInfo, "Order Details");
    }
  }
}
