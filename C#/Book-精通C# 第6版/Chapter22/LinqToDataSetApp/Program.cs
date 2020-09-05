using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  强类型数据容器所在的位置
using AutoLotDAL;
//  强类型数据适配器所在的位置
using AutoLotDAL.AutoLotDataSetTableAdapters;

namespace LinqToDataSetApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** LINQ over DataSet *****\n");

      //  获取包含AutoLot数据库中当期Inventory的强类型DataTable
      AutoLotDataSet dal = new AutoLotDataSet();
      InventoryTableAdapter da = new InventoryTableAdapter();
      AutoLotDataSet.InventoryDataTable data = da.GetData();

      PrintAllCarIDs(data);
      ShowRedCars(data);
      BuildDataTableFromQuery(data);
      Console.ReadLine();
    }

    static void PrintAllCarIDs(DataTable data)
    {
      //  获取DataTable可枚举的副本
      EnumerableRowCollection enumData = data.AsEnumerable();

      //  打印汽车的ID
      foreach (DataRow r in enumData)
      {
        Console.Write("Car ID = {0}", r["CarID"]);
      }
      Console.WriteLine();
    }

    static void ShowRedCars(DataTable data)
    {
      //  对Color=Red的行,投影包含ID/颜色的结果集
      var cars = from car in data.AsEnumerable()
                 where car.Field<string>("Color") == "Red"
                 select new
                 {
                   ID = car.Field<int>("CarID"),
                   Make = car.Field<string>("Make")
                 };
      Console.WriteLine("Here are the red cars we have in stock:");
      foreach (var item in cars)
      {
        Console.WriteLine("-> CarID = {0} is {1}", item.ID, item.Make);
      }
    }

    static void BuildDataTableFromQuery(DataTable data)
    {
      var cars = from car in data.AsEnumerable()
                 where car.Field<int>("CarID") > 5
                 select car;

      //  使用该结果集来构建新的DataTable
      DataTable newTable = cars.CopyToDataTable();
      //  打印DataTable
      for (int curRow = 0; curRow < newTable.Rows.Count; curRow++)
      {
        for (int curCol = 0; curCol < newTable.Columns.Count; curCol++)
        {
          Console.Write(newTable.Rows[curRow][curCol].ToString().Trim() + "\t");
        }
        Console.WriteLine();
      }
    }
  }
}
