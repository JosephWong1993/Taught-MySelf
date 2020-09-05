using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Data Readers *****\n");

            //  假设实际上是用*.config文件获取的cnStr
            string cnStr = @"Data Source=127.0.0.1;Initial Catalog=AutoLot;Integrated Security=SSPI;";

            SqlConnectionStringBuilder cnStrBuilder = new SqlConnectionStringBuilder(cnStr);
            //  改变timeout的值
            cnStrBuilder.ConnectTimeout = 5;

            //  建立并打开一个连接
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=127.0.0.1;Initial Catalog=AutoLot;Integrated Security=SSPI;";
                cn.Open();

                ShowConnectionStatus(cn);

                //  建立一个SQL命令对象
                string strSQL = "Select * From Inventory";
                SqlCommand myCommand = new SqlCommand(strSQL, cn);

                //  通过ExecuteReader()获取一个数据读取器
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    //  循环所以的记录
                    while (myDataReader.Read())
                    {
                        //Console.WriteLine("-> Make: {0},PetName: {1},Color: {2}.",
                        //    myDataReader["Make"].ToString(),
                        //    myDataReader["PetName"].ToString(),
                        //    myDataReader["Color"].ToString());
                        Console.WriteLine("***** Record *****");
                        for (int i = 0; i < myDataReader.FieldCount; i++)
                        {
                            Console.WriteLine("{0} = {1}",
                                myDataReader.GetName(i),
                                myDataReader.GetValue(i).ToString());
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }

        static void ShowConnectionStatus(SqlConnection cn)
        {
            //  显示当前连接对象的各种状态
            Console.WriteLine("***** Info about your connection *****");
            Console.WriteLine("Database location: {0}", cn.DataSource);
            Console.WriteLine("Database name: {0}", cn.Database);
            Console.WriteLine("Timeout: {0}", cn.ConnectionTimeout);
            Console.WriteLine("Connection state: {0}\n", cn.State.ToString());
        }
    }
}
