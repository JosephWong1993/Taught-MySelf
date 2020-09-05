using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  需要这些来获取公共接口的定义以及各种用于测试的连接对象
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Configuration;

namespace MyConnectionFactory
{
    //  可能的提供程序列表
    enum DataProvider
    {
        SqlServer,
        OleDb,
        Odbc,
        None
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Very Simple Connction Factory *****\n");

            //  读取提供程序键
            string dataProvString = ConfigurationManager.AppSettings["provider"];

            //  把字符串转换为枚举
            DataProvider dp = DataProvider.None;
            if (Enum.IsDefined(typeof(DataProvider), dataProvString))
                dp = (DataProvider)Enum.Parse(typeof(DataProvider), dataProvString);
            else
                Console.WriteLine("Sorry, no provider exists!");

            //  获取某个连接
            IDbConnection myCn = GetConnection(dp);
            Console.WriteLine("Your connection is a {0}", myCn.GetType().Name);

            //  打开,使用和关闭连接


            Console.ReadLine();
        }

        private static IDbConnection GetConnection(DataProvider dp)
        {
            IDbConnection conn = null;
            switch (dp)
            {
                case DataProvider.SqlServer:
                    conn = new SqlConnection();
                    break;
                case DataProvider.OleDb:
                    conn = new OleDbConnection();
                    break;
                case DataProvider.Odbc:
                    conn = new OdbcConnection();
                    break;
            }
            return conn;
        }
    }
}
