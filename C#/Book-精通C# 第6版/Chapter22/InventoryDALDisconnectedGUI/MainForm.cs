using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLotDisconnectedLayer;

namespace InventoryDALDisconnectedGUI
{
  public partial class MainForm : Form
  {
    InventoryDALDisLayer dal = null;

    public MainForm()
    {
      InitializeComponent();

      string cnStr = @"Data Source=127.0.0.1;Initial Catalog=AutoLot;" +
        "Integrated Security=True;Pooling=False";

      //  创建数据访问对象
      dal = new InventoryDALDisLayer(cnStr);

      //  填充网格
      inventoryGrid.DataSource = dal.GetAllInventory();
    }

    private void BtnUpdateInventory_Click(object sender, EventArgs e)
    {
      //  从网格获取修改后的数据
      DataTable changedDT = (DataTable)inventoryGrid.DataSource;

      try
      {
        //  提交我们的改动
        dal.UpdateInventory(changedDT);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
