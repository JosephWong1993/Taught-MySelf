using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace FillDataSetUsingSqlDataAdapter
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("**** Fun with Data Adapters *****\n");

      //  硬编码的连接字符串
      string cnStr = "Integrated Security = SSPI;Initial Catalog=Autolot;" +
        @"Data Source=127.0.0.1";

      //  调用者创建DataSet对象
      DataSet ds = new DataSet("AutoLot");

      //  告知适配器的Select命令文本和连接字符串
      SqlDataAdapter dAdapt =
        new SqlDataAdapter("Select * From Inventory", cnStr);

      //  现在映射列名到一个用户友好的名字
      DataTableMapping custMap = dAdapt.TableMappings.Add("Inventory", "Current Inventory");
      custMap.ColumnMappings.Add("CarID", "Car ID");
      custMap.ColumnMappings.Add("PetName", "Name of Car");
      dAdapt.Fill(ds, "Inventory");

      //  为DataSet填充一个叫Inventory的新表
      dAdapt.Fill(ds, "Inventory");

      //  显示DataSet的内容,使用本章前面创建的辅助方法;
      PrintDataSet(ds);

      Console.ReadLine();
    }

    private static void PrintDataSet(DataSet ds)
    {
      //  输出DataSet名称和扩展属性
      Console.WriteLine("DataSet is named: {0}", ds.DataSetName);
      foreach (System.Collections.DictionaryEntry de in ds.ExtendedProperties)
      {
        Console.WriteLine("Key = {0},Value = {1}", de.Key, de.Value);
      }
      Console.WriteLine();

      //  输出每一张表
      foreach (DataTable dt in ds.Tables)
      {
        Console.WriteLine("=> {0} Table:", dt.TableName);

        //  输出列名
        for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
        {
          Console.Write(dt.Columns[curCol].ColumnName + "\t");
        }
        Console.WriteLine("\n------------------------------------------");

        PrintTable(dt);
      }
    }

    static void PrintTable(DataTable dt)
    {
      //  得到DataTableReader类型
      DataTableReader dtReader = dt.CreateDataReader();

      //  像数据读取器一样操作DataTableReader
      while (dtReader.Read())
      {
        for (int i = 0; i < dtReader.FieldCount; i++)
        {
          Console.Write("{0}\t", dtReader.GetValue(i).ToString().Trim());
        }
        Console.WriteLine();
      }
      dtReader.Close();
    }

  }
}
