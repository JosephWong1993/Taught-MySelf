using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotDisconnectedLayer
{
  public class InventoryDALDisLayer
  {
    //  字段数据
    private string cnString = string.Empty;
    private SqlDataAdapter dAdapt = null;

    public InventoryDALDisLayer(string connectionString)
    {
      cnString = connectionString;

      //  配置SqlDataAdapter
      ConfigureAdapter(out dAdapt);
    }

    private void ConfigureAdapter(out SqlDataAdapter dAdapt)
    {
      //  创建适配器并且设置SelectCommand
      dAdapt = new SqlDataAdapter("Select * From Inventory", cnString);

      //  使用SqlCommandBuilder在运行时动态获取其余的命令对象
      SqlCommandBuilder builder = new SqlCommandBuilder(dAdapt);
    }

    public DataTable GetAllInventory()
    {
      DataTable inv = new DataTable("Inventory");
      dAdapt.Fill(inv);
      return inv;
    }

    public void UpdateInventory(DataTable modifiedTable)
    {
      dAdapt.Update(modifiedTable);
    }
  }
}
