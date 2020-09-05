using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotConnectedLayer;

namespace AdoNetTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Transaction Example *****\n");

            //  让事务成功或失败的简单方式
            bool throwEx = true;
            string userAnswer = string.Empty;
            Console.WriteLine("Do you want to throw an exception (Y or N):");
            userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "n")
            {
                throwEx = false;
            }

            InventoryDAL dal = new InventoryDAL();
            dal.OpenConnection(@"Data Source=127.0.0.1;Initial Catalog=AutoLot;Integrated Security=SSPI;");

            //  处理客户333
            dal.ProcessCreditRisk(throwEx, 333);

            Console.WriteLine("Check CreditRisk table for results");
            Console.ReadLine();
        }
    }
}
