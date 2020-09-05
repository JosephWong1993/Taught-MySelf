using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataProviderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Data Provider Factories *****\n");

            //  从*.config文件获取连接字符串和提供程序
            string dp = ConfigurationManager.AppSettings["provider"];
            //string cnStr = ConfigurationManager.AppSettings["cnStr"];
            string cnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

            //  得到工厂提供程序
            DbProviderFactory df = DbProviderFactories.GetFactory(dp);

            //  得到连接对象
            using (DbConnection cn = df.CreateConnection())
            {
                Console.WriteLine("Your connection object is a: {0}", cn.GetType().Name);
                cn.ConnectionString = cnStr;
                cn.Open();

                if (cn is SqlConnection)
                {
                    //  输出使用的SQLServer版本
                    Console.WriteLine((cn as SqlConnection).ServerVersion);
                }

                //  得到命令对象
                DbCommand cmd = df.CreateCommand();
                Console.WriteLine("Your command object is a: {0}", cmd.GetType().Name);
                cmd.Connection = cn;
                cmd.CommandText = "Select * From Inventory";

                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("Your data reader object is a: {0}", dr.GetType().Name);

                    Console.WriteLine("\n***** Current Inventory *****");
                    while (dr.Read())
                    {
                        Console.WriteLine("-> Car #{0} is a {1}.",
                            dr["CarID"], dr["Make"].ToString());
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
