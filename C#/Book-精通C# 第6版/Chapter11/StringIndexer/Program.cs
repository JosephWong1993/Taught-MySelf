using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StringIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Indexers *****\n");

            PersonCollection myPeople = new PersonCollection();

            myPeople["Homer"] = new Person("Homer", "Simpson", 40);
            myPeople["Marge"] = new Person("Marge", "Simpson", 38);

            //  获取"Homer"并输出数据
            Person homer = myPeople["Homer"];
            Console.WriteLine(homer.ToString());

            Console.ReadLine();
        }

        static void MultiIndexerWithDataTable()
        {
            //  创建一个包含3列的简单DataTable
            DataTable myTable = new DataTable();
            myTable.Columns.Add(new DataColumn("FirstName"));
            myTable.Columns.Add(new DataColumn("LastName"));
            myTable.Columns.Add(new DataColumn("Age"));

            //  向表中添加一行
            myTable.Rows.Add("Mel", "Appleby", 60);

            //  使用多维索引器获取第一行中的详细内容
            Console.WriteLine("First Name: {0}", myTable.Rows[0][0]);
            Console.WriteLine("Last Name: {0}", myTable.Rows[0][1]);
            Console.WriteLine("Age: {0}", myTable.Rows[0][2]);
        }
    }
}
