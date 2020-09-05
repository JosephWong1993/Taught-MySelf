using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL;
using AutoLotDAL.AutoLotDataSetTableAdapters;

namespace StronglyTypedDataSetConsoleClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Strongly Typed DataSets *****\n");

      AutoLotDataSet.InventoryDataTable table = new AutoLotDataSet.InventoryDataTable();

      InventoryTableAdapter dAdapt = new InventoryTableAdapter();
      dAdapt.Fill(table);

      PrintInventory(table);

      //  添加行,更新病再次打印
      AddRecords(table, dAdapt);
      table.Clear();
      dAdapt.Fill(table);
      PrintInventory(table);

      RemoveRecords(table, dAdapt);
      table.Clear();
      dAdapt.Fill(table);
      PrintInventory(table);

      CallStoredProc();

      Console.ReadLine();
    }

    private static void PrintInventory(AutoLotDataSet.InventoryDataTable dt)
    {
      //  打印列名
      for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
      {
        Console.Write(dt.Columns[curCol].ColumnName + "\t");
      }
      Console.WriteLine("\n-------------------------------");

      //  打印数据
      for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
      {
        for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
        {
          Console.Write(dt.Rows[curRow][curCol].ToString() + "\t");
        }
        Console.WriteLine();
      }
    }

    //  用生成的代码插入数据
    public static void AddRecords(AutoLotDataSet.InventoryDataTable tb,
      InventoryTableAdapter dAdapt)
    {
      try
      {
        //  从表中获取新的强类型的行
        AutoLotDataSet.InventoryRow newRow = tb.NewInventoryRow();

        //  使用一些示例数据填充该行
        newRow.CarID = 999;
        newRow.Color = "Purple";
        newRow.Make = "BMW";
        newRow.PetName = "Saku";

        //  插入新行
        tb.AddInventoryRow(newRow);

        //  使用重载的Add方法添加另一个行
        tb.AddInventoryRow(888, "Yugo", "Green", "Zippy");

        //  更新数据库
        dAdapt.Update(tb);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    //  用生成的代码删除数据
    private static void RemoveRecords(AutoLotDataSet.InventoryDataTable tb,
      InventoryTableAdapter dAdapt)
    {
      try
      {
        AutoLotDataSet.InventoryRow rowToDelete = tb.FindByCarID(999);
        dAdapt.Delete(rowToDelete.CarID, rowToDelete.Make,
          rowToDelete.Color, rowToDelete.PetName);

        rowToDelete = tb.FindByCarID(888);
        dAdapt.Delete(rowToDelete.CarID, rowToDelete.Make,
         rowToDelete.Color, rowToDelete.PetName);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    //  用生成的代码调用存储过程
    public static void CallStoredProc()
    {
      try
      {
        QueriesTableAdapter q = new QueriesTableAdapter();
        Console.WriteLine("Enter ID of car to look up");
        string carID = Console.ReadLine();
        string carName = "";
        q.GetPetName(int.Parse(carID), ref carName);
        Console.WriteLine("CarID {0} has the name of {1}", carID, carName);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
