using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using AutoLotConnectedLayer;

namespace AutoLotCUIclient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The AutoLot Console UI *****\n");

            //  从App.config获取连接字符串
            string cnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
            bool userDone = false;
            string userCommand = string.Empty;

            //  创建InventoryDAL对象
            InventoryDAL invDAL = new InventoryDAL();
            invDAL.OpenConnection(cnStr);

            //  不断请求输入,直到用户按下Q键
            try
            {
                ShowInstructions();
                do
                {
                    Console.WriteLine("\nPlease enter your command: ");
                    userCommand = Console.ReadLine();
                    Console.WriteLine();
                    switch (userCommand.ToUpper())
                    {
                        case "I":
                            InsertNewCar(invDAL);
                            break;
                        case "U":
                            UpdateCarPetName(invDAL);
                            break;
                        case "D":
                            DeleteCar(invDAL);
                            break;
                        case "L":
                            ListInventory(invDAL);
                            break;
                        case "S":
                            ShowInstructions();
                            break;
                        case "P":
                            LookUpPetName(invDAL);
                            break;
                        case "Q":
                            userDone = true;
                            break;
                        default:
                            Console.WriteLine("Bad data! Try again");
                            break;
                    }
                }
                while (!userDone);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                invDAL.CloseConnection();
            }
        }

        private static void LookUpPetName(InventoryDAL invDAL)
        {
            //  获取要查找的汽车的ID
            Console.WriteLine("Enter ID of car to look up: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Petname of {0} is {1}.",
                id, invDAL.LookUpPetName(id).TrimEnd());
        }

        private static void UpdateCarPetName(InventoryDAL invDAL)
        {
            //  首先获取用户数据
            int newCarID;
            string newCarPetName;

            Console.WriteLine("Enter Car ID: ");
            newCarID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Pet Name: ");
            newCarPetName = Console.ReadLine();

            //  现在传入数据访问类库
            invDAL.UpdateCarPetName(newCarID, newCarPetName);
        }

        private static void InsertNewCar(InventoryDAL invDAL)
        {
            //  首先获取用户数据
            int newCarID;
            string newCarColor, newCarMake, newCarPetName;

            Console.WriteLine("Enter Car ID: ");
            newCarID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Car Color: ");
            newCarColor = Console.ReadLine();

            Console.WriteLine("Enter Car Make: ");
            newCarMake = Console.ReadLine();

            Console.WriteLine("Enter Pet Name: ");
            newCarPetName = Console.ReadLine();

            //  现在传入数据访问类库
            //invDAL.InsertAuto(newCarID, newCarColor, newCarMake, newCarPetName);
            NewCar c = new NewCar
            {
                CarID = newCarID,
                Color = newCarColor,
                Make = newCarMake,
                PetName = newCarPetName
            };
            invDAL.InsertAuto(c);
        }

        private static void DeleteCar(InventoryDAL invDAL)
        {
            //  获取要删除的汽车ID
            Console.WriteLine("Enter ID of car to delete: ");
            int id = int.Parse(Console.ReadLine());

            //  以防违反引用完整性
            try
            {
                invDAL.DeleteCar(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ListInventory(InventoryDAL invDAL)
        {
            //  获取库存列表
            DataTable dt = invDAL.GetAllInventoryAsDataTable();

            //  将DataTable传递给辅助函数用于显示数据
            DisplayTable(dt);
        }

        private static void DisplayTable(DataTable dt)
        {
            //   输出列名
            for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
            {
                Console.Write(dt.Columns[curCol].ColumnName + "\t");
            }
            Console.WriteLine("\n------------------------------------");

            //  输出DataTable
            for (int curROw = 0; curROw < dt.Rows.Count; curROw++)
            {
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Console.Write(dt.Rows[curROw][curCol].ToString() + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void ShowInstructions()
        {
            Console.WriteLine("I: Inserts a new car.");
            Console.WriteLine("U: Updates an existing car.");
            Console.WriteLine("D: Deleted an existing car.");
            Console.WriteLine("L: Lists current inventory.");
            Console.WriteLine("S: Shows these instructions.");
            Console.WriteLine("P: Looks up pet name.");
            Console.WriteLine("Q: Quits program.");
        }
    }
}
