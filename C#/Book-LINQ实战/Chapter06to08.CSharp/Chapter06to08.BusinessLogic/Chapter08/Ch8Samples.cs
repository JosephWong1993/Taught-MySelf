using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter06to08.BusinessLogic.SampleHarness;
using Common;
using System.Data.Linq;
using System.Threading;

namespace Chapter06to08.BusinessLogic.Chapter08
{
    public class Ch8Samples : SampleClass
    {
        LinqBooksDataContext NewContext
        {
            get
            {
                return new LinqBooksDataContext() { Log = Console.Out };
            }
        }

        [Sample(8, 2, "8-2：LINQ to SQL中默认的乐观式并发实现")]
        public void DefaultConcurrencyImplementation_8_2()
        {
            LinqBooksDataContext context = this.NewContext;
            var mostExpensiveBook = (from book in context.Book
                                     orderby book.Price descending
                                     select book).First();

            decimal discount = .1M;
            mostExpensiveBook.Price -= mostExpensiveBook.Price * discount;

            //context.SubmitChanges();

            //Rather than committing a change, just view the SQL that would be used
            Console.WriteLine(context.GetChangeText());
        }

        [Sample(8, 3, "8-3：在Author表上使用时间戳列来保证乐观式并发")]
        public void ConcurrencyWithTimestamp_8_3()
        {
            LinqBooksDataContext context = new LinqBooksDataContext();

            var authorToChange = (context.Author).First();

            authorToChange.FirstName = "Jim";
            authorToChange.LastName = "Wooley";

            //Rather than committing a change, just view the SQL that would be used
            Console.WriteLine(context.GetChangeText());
        }

        [Sample(8, 4, "8-4：使用KeepChanges来解决冲突")]
        public void ConcurrencyKeepChanges_8_4()
        {
            LinqBooksDataContext context = this.NewContext;
            //Make some changes
            this.MakeConcurrentChanges(context);

            try
            {
                context.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                context.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
                //resubmit the merged values
                context.SubmitChanges();
            }
        }

        [Sample(8, 5, "8-5：让发生冲突的记录使用数据库中的当前值")]
        public void ConcurrencyOverwriteCurrentValues_8_5()
        {
            LinqBooksDataContext context = this.NewContext;
            //Make some changes
            this.MakeConcurrentChanges(context);

            try
            {
                context.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                context.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);
            }
        }

        [Sample(8, 6, "8-6：显示冲突的详细信息")]
        public void ConcurrencyDisplayingChanges_8_6()
        {
            LinqBooksDataContext context = new LinqBooksDataContext();
            //Make some changes
            this.MakeConcurrentChanges(context);

            try
            {
                context.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                var exceptionDetail =
                    from conflict in context.ChangeConflicts
                    from member in conflict.MemberConflicts
                    select new
                    {
                        TableName = Helpers.GetTableName(context, conflict.Object),
                        MemberName = member.Member.Name,
                        CurrentValue = member.CurrentValue.ToString(),
                        DatabaseValue = member.DatabaseValue.ToString(),
                        OriginalValue = member.OriginalValue.ToString()
                    };
                ObjectDumper.Write(exceptionDetail);
            }
        }

        [Sample(8, 7, "8-7：通过DataContext管理事务")]
        public void TransactionsDataContext_8_8()
        {
            LinqBooksDataContext context = this.NewContext;

            this.MakeConcurrentChanges(context);

            try
            {
                context.Connection.Open();
                context.Transaction = context.Connection.BeginTransaction();
                context.SubmitChanges(ConflictMode.ContinueOnConflict);
                context.Transaction.Commit();
            }
            catch (ChangeConflictException)
            {
                context.Transaction.Rollback();
            }
        }

        [Sample(8, 8, "8-8: 使用TransactionScope管理事务")]
        public void TransactionsSqlTransactionScope_8_8()
        {
            LinqBooksDataContext context = this.NewContext;

            this.MakeConcurrentChanges(context);

            using (System.Transactions.TransactionScope scope =
                   new System.Transactions.TransactionScope())
            {
                context.SubmitChanges(ConflictMode.ContinueOnConflict);
                scope.Complete();
            }
        }

        [Sample(8, 9, "8-9：直接使用SQL语句查询")]
        public void DynamicSql_8_9()
        {
            string SearchName = "Wooley";

            DynamicSql(SearchName);
        }
        private void DynamicSql(string searchName)
        {
            LinqBooksDataContext context = this.NewContext;

            string sql = @"Select ID, LastName, FirstName, WebSite, TimeStamp    " +
                "From dbo.Author " +
                "Where LastName = '" + searchName + "'";

            IEnumerable<Author> authors = context.ExecuteQuery<Author>(sql);
            ObjectDumper.Write(authors);
        }

        [Sample(8, 10, "8-10：直接使用参数化的SQL语句查询")]
        public void DynamicSqlParameters_8_10()
        {
            string searchName = "Good' OR ''='";

            LinqBooksDataContext context = this.NewContext;
            string sql =
                @"Select ID, LastName, FirstName, WebSite, TimeStamp  " +
                "From dbo.Author " +
                "Where LastName = {0}";

            // We should actually have 0 records returned in this case.
            ObjectDumper.Write(context.ExecuteQuery<Author>(sql, searchName));
        }

        [Sample(8, 11, "8-11：使用存储过程查询数据")]
        public void StoredProc_8_11()
        {
            Guid bookId = new Guid("0737c167-e3d9-4a46-9247-2d0101ab18d1");
            LinqBooksDataContext context = this.NewContext;
            IEnumerable<Book> query = context.GetBook_Custom(bookId, Thread.CurrentPrincipal.Identity.Name);

            ObjectDumper.Write(query);
        }

        [Sample(8, 13, "8-13：使用存储过程查询返回单一值")]
        public void StoredProcScalar_8_13()
        {
            Guid publisherId = new Guid("851e3294-145d-4fff-a190-3cab7aa95f76");
            LinqBooksDataContext context = this.NewContext;
            Console.WriteLine(String.Format("Books found: {0}",
                context.BookCountForPublisher(publisherId).ToString()));
        }

        [Sample(8, 16, "8-16：在LINQ中通过调用存储过程来更新记录")]
        public void UpdateProcedures_8_16()
        {
            LinqBooksDataContext context = this.NewContext;
            var changingAuthor = context.Author.FirstOrDefault<Author>();
            changingAuthor.FirstName = "Changing";
            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                context.SubmitChanges();
                //Let the transaction rollback
            }
        }

        [Sample(8, 19, "8-19：LINQ设计为标量函数自动生成的代理方法")]
        public void UserDefinedScalarFunctions_8_19()
        {
            LinqBooksDataContext context = this.NewContext;

            Guid? PublisherId = new Guid(@"855cb02e-dc29-473d-9f40-6c3405043fa3");
            Console.WriteLine(context.fnBookCountForPublisher(PublisherId));
        }

        [Sample(8, 20, "8-20：在查询中组合使用标量函数")]
        public void UserDefinedFunctionsInQuery_8_20()
        {
            LinqBooksDataContext context = this.NewContext;

            var query =
                from publisher in context.GetTable<Publisher>()
                select new
                {
                    publisher.Name,
                    BookCount = context.fnBookCountForPublisher(publisher.ID)
                };

            ObjectDumper.Write(query);
        }

        [Sample(8, 22, "8-22：使用用户自定义函数")]
        public void UserDefinedFunctions_8_22()
        {
            LinqBooksDataContext context = this.NewContext;

            Guid publisherId = new Guid("855cb02e-dc29-473d-9f40-6c3405043fa3");
            var query1 =
              from book in context.fnGetPublishersBooks(publisherId)
              select new
              {
                  book.Title,
                  OtherBookCount = context.fnBookCountForPublisher1(book.Publisher) - 1
              };
            ObjectDumper.Write(query1);
        }

        [Sample(8, 23, "8-23：预编译查询")]
        public void CompiledQuery_8_23()
        {
            ObjectDumper.Write(LinqBooksDataContext.GetExpensiveBooks(30));
        }

        [Sample(8, 25, "8-25：查询定义在部分类中的属性")]
        public void QueryingPartialClass_8_25()
        {
            LinqBooksDataContext context = this.NewContext;
            var partialAuthors = from author in context.Author
                                 select author;
            ObjectDumper.Write(partialAuthors);
        }

        [Sample(8, 26, "8-26：在自定义部分类中实现IDataErrorInfo接口")]
        public void ConsumingIDataErrorInfo_9_26()
        {
            EditingForm frm = new EditingForm();
            frm.ShowDialog();
        }

        [Sample(8, 28, "8-28：在LINQ to SQL在获取存在继承关系的对象")]
        public void QueryingInheritance_8_28()
        {
            LinqBooksDataContext context = new LinqBooksDataContext();
            context.Log = Console.Out;

            //Get all users from the base instance
            Console.WriteLine("All users:");
            var query =
                from user in context.User
                select user.Name;
            ObjectDumper.Write(query);

            Console.WriteLine();
            Console.WriteLine("Authors: ");
            //Get only the authors
            var authors =
                from user in context.User
                where user is AuthorUser
                select user.Name;
            ObjectDumper.Write(authors);

            Console.WriteLine();
            Console.WriteLine("Publishers: ");
            //Get the publishers using the OfType extension method
            var publishers =
                from user in context.User.OfType<PublisherUser>()
                select user.Name;
            ObjectDumper.Write(publishers);

        }

        private void MakeConcurrentChanges(LinqBooksDataContext context)
        {
            LinqBooksDataContext context1 = this.NewContext;

            //First user raises the price of each book
            var books1 = context1.Book;
            foreach (var book in books1)
            {
                book.Price += 2;
            }

            //Second user lowers the price of each book
            var books2 = context.Book;
            foreach (var book in books2)
            {
                book.Price -= 1;
            }
            //Go ahead and submit the first changes. 
            //The submit using the context passed in to this method will fail.
            context1.SubmitChanges();
        }
    }
}
