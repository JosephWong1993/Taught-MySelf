using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL;

namespace AutoLotEDMClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Navigation Properties *****");

      //Console.Write("Plese enter customer ID: ");
      //string custID = Console.ReadLine();
      //PrintCustomerOrders(custID);

      CallStoredProc();

      Console.ReadLine();
    }

    private static void PrintCustomerOrders(string custID)
    {
      int id = int.Parse(custID);

      using (AutoLotEntities context = new AutoLotEntities())
      {
        IQueryable<Inventory> carsOnOrder = from o in context.Orders
                                            where o.CustID == id
                                            select o.Inventory;
        Console.WriteLine("\nCustomer has {0} orders pending:", carsOnOrder.Count());
        foreach (var item in carsOnOrder)
        {
          Console.WriteLine("-> {0} {1} named {2}.",
            item.Color, item.Make, $"{item.PetName}".Trim());
        }
      }
    }

    private static void CallStoredProc()
    {
      using (AutoLotEntities context = new AutoLotEntities())
      {
        //  方法 #1
        ObjectParameter input = new ObjectParameter("carID", 83);
        ObjectParameter output = new ObjectParameter("petName", typeof(string));

        //  调用上下文的ExecuteFunction方法
        //context.ExecuteFunction("GetPetName", input, output);

        //  方法 #2
        //  或使用上下文中强类型的方法
        context.GetPetName(83, output);

        Console.WriteLine("Car #83 is named {0}", output.Value);
      }
    }
  }
}
