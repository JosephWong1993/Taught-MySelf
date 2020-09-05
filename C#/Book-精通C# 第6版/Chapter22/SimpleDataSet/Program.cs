using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleDataSet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with DataSets *****\n");

      ManipulateDataRowState();

      //  建立DataSet对象并添加一些属性
      DataSet carsInventoryDS = new DataSet("Car Inventory");

      carsInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
      carsInventoryDS.ExtendedProperties["DataSetID"] = Guid.NewGuid();
      carsInventoryDS.ExtendedProperties["Company"] = "Mikko's Hot Tub Super Store";

      FillDataSet(carsInventoryDS);
      PrintDataSet(carsInventoryDS);

      SaveAndLoadAsXml(carsInventoryDS);
      SaveAndLoadAdBinary(carsInventoryDS);
      Console.ReadLine();
    }

    private static void ManipulateDataRowState()
    {
      //  创建一个临时DataTable用于测试
      DataTable temp = new DataTable("Temp");
      temp.Columns.Add(new DataColumn("TempColumn", typeof(int)));

      //  RowState=Detached(i.e. not part of a DataTable yet)
      DataRow row = temp.NewRow();
      Console.WriteLine("After calling NewRow(): {0}", row.RowState);

      //  RowState=Added
      temp.Rows.Add(row);
      Console.WriteLine("After calling Rows.Add(): {0}", row.RowState);

      //  RowState=Added
      row["TempColumn"] = 10;
      Console.WriteLine("After first assignment: {0}", row.RowState);

      //  RowState=Unchanged
      temp.AcceptChanges();
      Console.WriteLine("After calling AcceptChanges: {0}", row.RowState);

      //  RowState=Modified
      row["TempColumn"] = 11;
      Console.WriteLine("After first assignment: {0}", row.RowState);

      //  RowState=Deleted
      temp.Rows[0].Delete();
      Console.WriteLine("After calling Delete: {0}", row.RowState);
    }

    static void FillDataSet(DataSet ds)
    {
      //  建立对于AutoLot数据库Inventory表真实字段的数据列
      DataColumn carIDColumn = new DataColumn("CarID", typeof(int));
      carIDColumn.Caption = "Car ID";
      carIDColumn.ReadOnly = true;
      carIDColumn.AllowDBNull = false;
      carIDColumn.Unique = true;

      //  启用自增列
      carIDColumn.AutoIncrement = true;
      carIDColumn.AutoIncrementSeed = 0;
      carIDColumn.AutoIncrementStep = 1;

      DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
      DataColumn carColorColumn = new DataColumn("Color", typeof(string));
      DataColumn carPetNameColumn = new DataColumn("PetName", typeof(string));
      carPetNameColumn.Caption = "Pet Name";

      //  把DataColumn加入到DataTable
      DataTable inventoryTable = new DataTable("Inventory");
      inventoryTable.Columns.AddRange(new DataColumn[]
      {
        carIDColumn,carMakeColumn,carColorColumn,carPetNameColumn
      });

      //  现在为Inventory表增加一些行
      DataRow carRow = inventoryTable.NewRow();
      carRow["Make"] = "BMW";
      carRow["Color"] = "Black";
      carRow["PetName"] = "Hamlet";
      inventoryTable.Rows.Add(carRow);

      carRow = inventoryTable.NewRow();
      //  第0列是自增ID字段,因此从1开始
      //  如果传入DataRow索引起方法的是无效的列名或无效的顺序位置,我们就会收到运行时异常.
      carRow[1] = "Saab";
      carRow[2] = "Red";
      carRow[3] = "Sea Breeze";
      inventoryTable.Rows.Add(carRow);

      //  为这个表指定主键
      inventoryTable.PrimaryKey = new DataColumn[] { inventoryTable.Columns[0] };

      //  最后,把我们的表加入到DataSet
      ds.Tables.Add(inventoryTable);
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

        //  输出DataTable
        //for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
        //{
        //    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
        //    {
        //        Console.Write(dt.Rows[curRow][curCol].ToString() + "\t");
        //    }
        //    Console.WriteLine();
        //}

        //  调用新的辅助方法
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

    //  序列化DataTable/DataSet对象为XML
    static void SaveAndLoadAsXml(DataSet carsInventoryDS)
    {
      //  保存这个DataSet为XML
      carsInventoryDS.WriteXml("carsDataSet.xml");
      carsInventoryDS.WriteXmlSchema("carsDataSet.xsd");

      //  清楚DataSet
      carsInventoryDS.Clear();

      //  从XML文件中加载DataSet
      carsInventoryDS.ReadXml("carsDataSet.xml");
    }

    //  以二进制格式序列化DataTable/DataSet对象
    static void SaveAndLoadAdBinary(DataSet carsInventoryDS)
    {
      //  设置二进制序列号标记
      carsInventoryDS.RemotingFormat = SerializationFormat.Binary;

      //  以二进制格式保存DataSet
      FileStream fs = new FileStream("BinaryCars.bin", FileMode.Create);
      BinaryFormatter bFormat = new BinaryFormatter();
      bFormat.Serialize(fs, carsInventoryDS);
      fs.Close();

      //  清空DataSet
      carsInventoryDS.Clear();

      //  从二进制文件加载DataSet
      fs = new FileStream("BinaryCars.bin", FileMode.Open);
      DataSet data = (DataSet)bFormat.Deserialize(fs);
    }
  }
}
