using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Chapter14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnTestLoading_Click(object sender, EventArgs e)
        {
            //  加载DataSet
            DataSet dataSet = new DataSet();
            //FillDataSetUsingDataAdapter(dataSet);
            FillDataSetUsingLinqToSql(dataSet);
            DataTable publisherTable = dataSet.Tables[0];
            DataTable bookTable = dataSet.Tables[1];
            //var publisherBooks = from publisher in publisherTable.AsEnumerable()
            //                     join book in bookTable.AsEnumerable()
            //                         on publisher.Field<Guid>("ID") equals book.Field<Guid>("publisher")    //  用出版商ID作为连接条件连接Publisher和Book表
            //                     select new //  从两张表中获取数据
            //                     {
            //                         Publisher = publisher.Field<String>("Name"),
            //                         Book = book.Field<String>("Title")
            //                     };
            dataSet.Relations.Add("PublisherBooks", publisherTable.Columns["ID"], bookTable.Columns["Publisher"]);  //  创建出版商和其图书之间的关系
            var publisherBooks = from publisher in publisherTable.AsEnumerable()
                                 from book in publisher.GetChildRows("PublisherBooks")
                                 select new
                                 {
                                     Publisher = publisher.Field<String>("Name"),
                                     Book = book.Field<String>("Title")
                                 };

            var filteredBooks = from book in bookTable.AsEnumerable()   //  将DataTable转换为IEnumerable<DataRow>
                                where book.Field<String>("Title").StartsWith("L")
                                select new
                                {
                                    Title = book.Field<String>("Title"),    //  使用Field操作符获取字段的值 
                                    Price = book.Field<decimal?>("Price")   //  Field操作符将透明地处理可空类型
                                };

            LinqBooksDataSet dataSet2 = new LinqBooksDataSet();
            FillDataSetUsingLinqToSql(dataSet2);
            var query = from publisher in dataSet2.Publisher
                        join book in dataSet2.Book
                        on publisher.ID equals book.Publisher
                        select new
                        {
                            Publisher = publisher.Name,
                            Book = book.Title
                        };

            dataGridView1.DataSource = query.ToList();
            dataGridView2.DataSource = filteredBooks.ToList();
        }

        void FillDataSetUsingDataAdapter(DataSet dataSet)
        {
            //  Create the DataAdapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                @"select ID,Name from Publisher;select ID,Title,Subject,Publisher,Price from Book where DatePart(year,pubdate)>1950 ",
                ConfigurationManager.ConnectionStrings["Chapter14.Properties.Settings.LiaConnectionString"].ConnectionString);

            //  Map the results to tables in the DataSet
            dataAdapter.TableMappings.Add("Table", "Publisher");
            dataAdapter.TableMappings.Add("Table1", "Book");

            //  Execute the SQL queries and load the data into the DataSet
            dataAdapter.Fill(dataSet);
        }

        void FillDataSetUsingLinqToSql(DataSet dataSet)
        {
            DataTable table;
            LinqBooksDataContext linqBooks = new LinqBooksDataContext();    //  准备LINQ to SQL 的DataContext

            var publisherQuery =
                from publisher in linqBooks.Publisher
                select new { publisher.ID, publisher.Name };

            var bookQuery = from book in linqBooks.Book
                            where book.PubDate.Value.Year > 1950
                            select new
                            {
                                book.ID,
                                book.Title,
                                book.Subject,
                                book.Publisher,
                                Price = book.Price.HasValue ? book.Price.Value : 0
                            };

            table = new DataTable();
            table.Columns.Add("ID", typeof(Guid));
            table.Columns.Add("Name", typeof(String));

            foreach (var publisher in publisherQuery)
            {
                table.LoadDataRow(new Object[] { publisher.ID, publisher.Name }, true);
            }
            dataSet.Tables.Add(table);

            table = new DataTable();
            table.Columns.Add("ID", typeof(Guid));
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Subject", typeof(Guid));
            table.Columns.Add("Publisher", typeof(Guid));
            table.Columns.Add("Price", typeof(decimal));

            foreach (var book in bookQuery)
            {
                table.LoadDataRow(new Object[] { book.ID, book.Title, book.Subject, book.Publisher, book.Price }, true);
            }
            dataSet.Tables.Add(table);
        }

        void FillDataSetUsingLinqToSql2(DataSet dataSet)
        {
            //DataTable table;

            ////  Prepare the LINQ to SQL DataContext
            //var linqBooks = new LinqBooksDataContext();

            ////  Query the Publisher table
            //var publisherQuery = from publisher in linqBooks.Publisher
            //                     select new { publisher.ID, publisher.Name };

            ////  Query the Book table
            //var bookQuery = from book in linqBooks.Book
            //                where book.PubDate.Value.Year > 1950
            //                select new
            //                {
            //                    book.ID,
            //                    book.Title,
            //                    book.Subject,
            //                    book.Publisher,
            //                    book.PageCount,
            //                    Price = book.Price.HasValue ? book.Price.Value : 0
            //                };

            //dataSet.Tables.Add(publisherQuery.TaDataTable());
            //dataSet.Tables.Add(bookQuery.ToDataTable());
        }

        void FillDataSetUsingLinqToSql(LinqBooksDataSet dataSet)
        {
            var linqBooks = new LinqBooksDataContext(); //  准备LINQtoSQLDataContext

            var publisherQuery = from publisher in linqBooks.Publisher
                                 select new { publisher.ID, publisher.Name };   //  查询数据表

            var bookQuery = from book in linqBooks.Book
                            where book.PubDate.Value.Year > 1950
                            select new
                            {
                                book.ID,
                                book.Title,
                                book.Subject,
                                book.Publisher,
                                Price = book.Price.HasValue ? book.Price.Value : 0
                            };
            foreach (var publisher in publisherQuery)
            {
                dataSet.Publisher.AddPublisherRow(publisher.ID, publisher.Name, null, null);
            }

            foreach (var book in bookQuery)
            {
                dataSet.Book.AddBookRow(book.ID, null, null, 0, book.Price, DateTime.MinValue, dataSet.Publisher.FindByID(book.Publisher), book.Subject, null, book.Title);
            }
        }
    }
}
