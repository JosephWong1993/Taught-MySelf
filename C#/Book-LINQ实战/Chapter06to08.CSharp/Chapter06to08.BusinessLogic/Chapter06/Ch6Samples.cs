using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter06to08.BusinessLogic.SampleHarness;
using Chapter06to08.BusinessLogic.Chapter06.Unmapped;
using Common;
using System.Data.Linq;
using System.Configuration;

namespace Chapter06to08.BusinessLogic.Chapter06
{
    public class Ch6Samples : SampleClass
    {
        public Ch6Samples() : base() { }

        [Sample(6, 1, "6-1：通过LINQ to Objects查询Books和Subjects集合")]
        public void StartingQuery_6_1()
        {
            IEnumerable<Chapter06to08.BusinessLogic.Chapter06.Unmapped.Book> books = Chapter06to08.BusinessLogic.Chapter06.Unmapped.Book.GetBooks();
            IEnumerable<Chapter06to08.BusinessLogic.Chapter06.Unmapped.Subject> subjects = Chapter06to08.BusinessLogic.Chapter06.Unmapped.Subject.GetSubjects();

            var query = from subject in subjects
                        join book in books on subject.SubjectId equals book.SubjectId
                        //where book.Price < 30
                        orderby subject.Description, book.Title
                        select new
                        {
                            subject.Description,
                            book.Title,
                            book.Price
                        };
            ObjectDumper.Write(query, 1);
        }

        [Sample(6, 2, "6-2：查询出低于30美元的图书的标题和价格")]
        public void StartingBooksUnmapped_6_2()
        {
            IEnumerable<Chapter06to08.BusinessLogic.Chapter06.Unmapped.Book> books = Chapter06to08.BusinessLogic.Chapter06.Unmapped.Book.GetBooks();
            var query = from book in books
                        where book.Price < 30
                        orderby book.Title
                        select new
                        {
                            book.Title,
                            book.Price
                        };
            ObjectDumper.Write(query, 1);
        }

        [Sample(6, 5, "6-5：使用LINQ to SQL获取图书对象")]
        public void StartingBooksFetch_6_5()
        {
            using (DataContext db = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                db.Log = Console.Out;
                var query = from book in db.GetTable<Book>()
                            select book;
                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 6, "6-6：查询图书标题")]
        public void StartingBooksFetchWithProjection_6_6()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                IEnumerable<String> query =
                    from book in dataContext.GetTable<Book>()
                    select book.Title;

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 7, "6-7：投影至匿名类型")]
        public void StartingBooksFetchWithAnonymousProjection_6_7()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var query = from book in dataContext.GetTable<Book>()
                            select new
                            {
                                book.Title,
                                book.Price
                            };

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 8, "6-8：以组合的方式添加分页功能")]
        public void FetchingWithPaging_6_8()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var books = dataContext.GetTable<Book>();
                var query = from book in books  //  定义query
                            select new
                            {
                                book.Title,
                                book.Price
                            };
                var pagedTitles = query.Skip(2);    //  分页
                var titlesToShow = pagedTitles.Take(2);

                ObjectDumper.Write(titlesToShow);   //  求值      
            }
        }

        [Sample(6, 10, "6-10：根据范围进行过滤")]
        public static void FilteringUsingRange_6_10()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var books = dataContext.GetTable<Book>();
                var query = from book in books
                            where book.Price < 30
                            select book;

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 11, "6-11：使用映射后CLR方法")]
        public void FilteringMappedClrMethods()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var books = dataContext.GetTable<Book>();
                var query = from book in books
                            where book.Title.Contains("on")
                            select book.Title;

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 11, "6-11a：使用未映射CLR方法")]
        public void FilteringUnmappedClrMethods_6_11a()
        {
            Console.WriteLine("This example will intentionally fail because it uses CLR methods improperly.");

            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var books = dataContext.GetTable<Book>();

                var query =
                    from book in books
                    where book.PublicationDate >= DateTime.Parse("1/1/2007")
                    select book.PublicationDate.ToString("MM/dd/yyyy");

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 12, "6-12：使用LINQ to SQL进行排序")]
        public void Sorting_6_12()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var books = dataContext.GetTable<Book>();
                var query = from book in books
                            where book.Price < 30
                            orderby book.Title
                            select book.Title;

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 13, "6-13：分组和排序")]
        public void Grouping_6_13()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var query =
                    from book in dataContext.GetTable<Book>()
                    group book by book.SubjectId into groupedBooks
                    orderby groupedBooks.Key
                    select new
                    {
                        SubjectId = groupedBooks.Key,
                        Books = groupedBooks
                    };

                foreach (var groupedBook in query)
                {
                    Console.WriteLine("Subject: {0}", groupedBook.SubjectId);
                    foreach (Book item in groupedBook.Books)
                    {
                        Console.WriteLine("Book: {0}", item.Title);
                    }
                }
            }
        }

        [Sample(6, 14, "6-14：在结果中执行聚焦操作")]
        public void Aggregates_6_14()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                Table<Book> books = dataContext.GetTable<Book>();
                var query = from book in books
                            group book by book.SubjectId into groupedBooks
                            select new
                            {
                                groupedBooks.Key,
                                BookCount = groupedBooks.Count()
                            };

                ObjectDumper.Write(query, 1);
            }
        }

        [Sample(6, 15, "6-15：使用多种聚集操作")]
        public void Aggregates_6_15()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                Table<Book> books = dataContext.GetTable<Book>();
                var query =
                    from book in books
                    group book by book.SubjectId into groupedBooks
                    select new
                    {
                        groupedBooks.Key,
                        TotalPrice = groupedBooks.Sum(b => b.Price),
                        LowPrice = groupedBooks.Min(b => b.Price),
                        HighPrice = groupedBooks.Max(b => b.Price),
                        AveragePrice = groupedBooks.Average(b => b.Price)
                    };

                ObjectDumper.Write(query, 1);
            }
        }

        [Sample(6, 16, "6-16：连接Book和Subject表")]
        public void Joining_6_16()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var subjects = dataContext.GetTable<Subject>();
                var books = dataContext.GetTable<Book>();
                var query = from subject in subjects
                            from book in books
                            where subject.SubjectId == book.SubjectId
                            select new { subject.Name, book.Title, book.Price };

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 17, "6-17：使用join关键字查询")]
        public void Joining_6_17()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var subjects = dataContext.GetTable<Subject>();
                var books = dataContext.GetTable<Book>();

                var query = from subject in subjects
                            join book in books on subject.SubjectId equals book.SubjectId
                            select new { subject.Name, book.Title, book.Price };

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 18, "6-18：模拟实现外连接")]
        public void Joining_6_18()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                var books = dataContext.GetTable<Book>();
                var Subjects = dataContext.GetTable<Subject>();
                var query =
                    from subject in Subjects
                    join book in books
                       on subject.SubjectId equals book.SubjectId into joinedBooks
                    from joinedBook in joinedBooks.DefaultIfEmpty()
                    select new
                    {
                        subject.Name,
                        joinedBook.Title,
                        joinedBook.Price
                    };

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 19, "6-19：使用LINQ to SQL重写原有的示例程序")]
        public void OriginalRewritten_6_19()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                Table<Subject> subjects = dataContext.GetTable<Subject>();
                Table<Book> books = dataContext.GetTable<Book>();

                var query = from subject in subjects
                            join book in books
                               on subject.SubjectId equals book.SubjectId
                            where book.Price < 30
                            orderby subject.Name
                            select new
                            {
                                subject.Name,
                                book.Title,
                                book.Price
                            };

                ObjectDumper.Write(query);
            }
        }

        [Sample(6, 21, "6-21：遍历对象的层级结构")]
        public void ObjectTrees_6_21()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                foreach (Subject subject in dataContext.GetTable<Subject>())
                {
                    Console.WriteLine(subject.Name);
                    foreach (Book book in subject.Books)
                    {
                        Console.WriteLine("...{0}", book.Title);
                    }
                }
            }
        }

        [Sample(6, 22, "6-22：在对象层级结构中使用Any实现内连接功能")]
        public void ObjectTrees_6_22()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;
                var Subjects = dataContext.GetTable<Subject>();

                var query = from subject in Subjects
                            where subject.Books.Any()
                            select subject;

                ObjectDumper.Write(query, 1);
            }
        }

        [Sample(6, 23, "6-23：使用All过滤子对象")]
        public void ObjectTrees_6_23()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;
                var Subjects = dataContext.GetTable<Subject>();

                var query = from subject in Subjects
                            where subject.Books.All(b => b.Price < 30)
                            select subject;

                ObjectDumper.Write(query, 1);
            }
        }

        [Sample(6, 24, "6-24：使用对象层级关系进行查询的示例程序")]
        public void OriginalRewrittenHeirarchical_6_24()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                Table<Subject> subjects = dataContext.GetTable<Subject>();

                var query = from subject in subjects
                            orderby subject.Name
                            select new
                            {
                                subject.Name,
                                Books = from book in subject.Books
                                        where book.Price < 30
                                        select new { book.Title, book.Price }
                            };

                ObjectDumper.Write(query, 1);
            }
        }

        [Sample(6, 25, "6-25：延迟加载子对象")]
        public void LazyLoadingChildren_6_25()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                Table<Subject> subjects = dataContext.GetTable<Subject>();
                ObjectDumper.Write(subjects, 1);
            }
        }

        [Sample(6, 27, "6-27：使用DataLoadOptions优化对象的加载")]
        public void LoadOptions_6_27()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                dataContext.Log = Console.Out;

                DataLoadOptions options = new DataLoadOptions();
                options.LoadWith<Subject>(Subject => Subject.Books);
                dataContext.LoadOptions = options;

                var query = dataContext.GetTable<Subject>();

                ObjectDumper.Write(query, 1);
            }
        }

        [Sample(6, 28, "6-28：更新对象的值并提交回数据库")]
        public void Updating_6_28()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                var ExpensiveBooks =
                    from b in dataContext.GetTable<Book>()
                    where b.Price > 30
                    select b;

                foreach (Book b in ExpensiveBooks)
                {
                    b.Price -= 5;
                }
                //Rather than commiting the update, we'll just print out the SQL to keep the database values.
                Console.WriteLine(Helpers.GetChangeText(dataContext));
                //dataContext.SubmitChanges();
            }
        }

        [Sample(6, 29, "6-29：对某张表执行添加和删除操作")]
        public void Insert_6_29()
        {
            using (DataContext dataContext = new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString))
            {
                Table<Book> books = dataContext.GetTable<Book>();

                Book newBook = new Book();
                newBook.Price = 40;
                newBook.PublicationDate = System.DateTime.Today;
                newBook.Title = "LINQ In Action";
                newBook.PublisherId = new Guid("4ab0856e-51f3-4b67-9355-8b11510119ba");
                newBook.SubjectId = new Guid("a0e2a5d7-88c6-4dfe-a416-10eadb978b0b");

                books.InsertOnSubmit(newBook);

                //Rather than commiting the update, we'll just print out the SQL to keep the database values.
                Console.WriteLine(Helpers.GetChangeText(dataContext));
                //dataContext.SubmitChanges();

                //Now delete it
                books.DeleteOnSubmit(newBook);

                //Rather than commiting the update, we'll just print out the SQL to keep the database values.
                Console.WriteLine(Helpers.GetChangeText(dataContext));
                //dataContext.SubmitChanges();
            }
        }
    }
}