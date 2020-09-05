using System;
using System.Collections.Generic;
using System.Data;
using System.Data.EntityClient;
using System.Linq;
using System.Text;

namespace InventoryEDMConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with ADO.NET EF *****");
      AddNewRecord();
      PrintAllInventory();

      //UpdateRecord();

      //FunWithLINQQueries();

      //FunWIthEntitySQL();

      //RemoveRecord();

      Console.ReadLine();
    }

    private static void AddNewRecord()
    {
      //  向AutoLot数据库的Inventory表添加一条记录
      using (AutoLotEntities context = new AutoLotEntities())
      {
        try
        {
          //  对新的记录进行硬编码,仅供测试
          context.AddToCars(new Car()
          {
            CarID = 2222,
            Make = "Yugo",
            Color = "Brown"
          });
          context.SaveChanges();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.InnerException.Message);
        }
      }
    }

    private static void PrintAllInventory()
    {
      //  选择AutoLot中Inventory表的所有记录,并使用Car实体类的自定义ToString()方法打印其数据
      using (AutoLotEntities context = new AutoLotEntities())
      {
        foreach (Car c in context.Cars)
        {
          Console.WriteLine(c);
        }
      }
    }

    private static void RemoveRecord()
    {
      //  通过主键查找要删除的汽车
      using (AutoLotEntities context = new AutoLotEntities())
      {
        //  为查找的实体定义主键
        //EntityKey key = new EntityKey("AutoLotEntity.Cars", "CarID", 2222);

        //  查找实体,如果存在的话将其删除
        //Car carToDelete = (Car)context.GetObjectByKey(key);
        var carToDelete = (from c in context.Cars
                           where c.CarID == 2222
                           select c).FirstOrDefault();
        if (carToDelete != null)
        {
          context.DeleteObject(carToDelete);
          context.SaveChanges();
        }
      }
    }

    private static void UpdateRecord()
    {
      //  通过主键查找要更新的汽车
      using (AutoLotEntities context = new AutoLotEntities())
      {
        //  为查找的实体定义主键
        EntityKey key = new EntityKey("AutoLotEntities.Cars", "CarID", 2222);

        //  查找实体,如果存在的话将其删除
        Car carToUpdate = (Car)context.GetObjectByKey(key);
        if (carToUpdate != null)
        {
          carToUpdate.Color = "Blue";
          context.SaveChanges();
        }
      }
    }

    private static void FunWithLINQQueries()
    {
      using (AutoLotEntities context = new AutoLotEntities())
      {
        //  获取新数据的投影
        var colorsMakes = from item in context.Cars
                          select new
                          {
                            item.Color,
                            item.Make
                          };
        foreach (var item in colorsMakes)
        {
          Console.WriteLine(item);
        }

        //  只获取CarID<1000的记录
        var idsLessThan1000 = from item in context.Cars
                              where item.CarID < 1000
                              select item;
        foreach (var item in idsLessThan1000)
        {
          Console.WriteLine(item);
        }
      }
    }

    private static void FunWIthEntitySQL()
    {
      using (AutoLotEntities context = new AutoLotEntities())
      {
        //  构建一个包含Entity SQL语法的字符串
        string query = "SELECT VALUE car FROM AutoLotEntities.Cars " +
          "AS car WHERE car.Color='black'";

        //  现在基于该字符串构建一个ObjectQuery<T>
        var blackCars = context.CreateQuery<Car>(query);
        foreach (var item in blackCars)
        {
          Console.WriteLine(item);
        }
      }
    }

    private static void FunWIthEntityDataReader()
    {
      //  基于*.config文件创建一个连接对象
      using (EntityConnection cn = new EntityConnection("name=AutoLotEntities"))
      {
        cn.Open();

        //  构建一个Entity SQL查询
        string query = "SELECT VALUE car FROM AutoLotEntities.Cars AS car";

        //  创建一个命令对象
        using (EntityCommand cmd = cn.CreateCommand())
        {
          cmd.CommandText = query;

          //  最后,获取数据阅读器并处理得到的记录
          using (EntityDataReader dr = cmd.ExecuteReader(CommandBehavior.SequentialAccess))
          {
            while (dr.Read())
            {
              Console.WriteLine("***** RECORD *****");
              Console.WriteLine("ID: {0}", dr["CarID"]);
              Console.WriteLine("Make: {0}", dr["Make"]);
              Console.WriteLine("Color: {0}", dr["Color"]);
              Console.WriteLine("Pet Name: {0}", dr["CarNickname"]);
              Console.WriteLine();
            }
          }
        }
      }
    }
  }
}
