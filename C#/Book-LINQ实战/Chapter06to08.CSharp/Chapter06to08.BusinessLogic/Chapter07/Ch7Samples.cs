using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter06to08.BusinessLogic.SampleHarness;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Configuration;
using Common;
using Chapter06to08.BusinessLogic;
using System.Linq.Expressions;

namespace Chapter06to08.BusinessLogic.Chapter07
{
    public class Ch7Samples : SampleClass
    {
        [Sample(7, 2, "7-2：将外部XML文件传递给DataContext")]
        public void XmlMapping_7_2()
        {
            XmlMappingSource map = XmlMappingSource.FromXml(System.IO.File.ReadAllText(@"lia.xml"));
            using (DataContext dataContext =
                new DataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString, map))
            {
                var authors = dataContext.GetTable<AuthorXml>();
                ObjectDumper.Write(authors);
            }
        }

        [Sample(7, 3, "7-3：被转换成的表达式树的查询")]
        public void QueryExpressions_7_3()
        {
            LinqBooksDataContext context = new LinqBooksDataContext();

            var bookParam = Expression.Parameter(typeof(Book), "book");

            var query = context.Book.Where<Book>(
                Expression.Lambda<Func<Book, bool>>(
                    Expression.GreaterThan(
                        Expression.Property(bookParam, typeof(Book).GetProperty("Price")), 
                        Expression.Constant(30M, typeof(decimal?))), 
                    new ParameterExpression[] { bookParam }));

            ObjectDumper.Write(query);
        }

        [Sample(7, 4, "7-4：标识管理和变化跟踪")]
        public void LifecycleTestWithoutSubmit_7_4()
        {
            LinqBooksDataContext context1 = new LinqBooksDataContext();
            LinqBooksDataContext context2 = new LinqBooksDataContext();

            context1.Log = Console.Out;
            context2.Log = Console.Out;

            Guid Id = new Guid("92f10ca6-7970-473d-9a25-1ff6cab8f682");

            Subject editingSubject = context1.Subject.Where(s => s.ID == Id).SingleOrDefault();

            Console.WriteLine("Before Change:");
            ObjectDumper.Write(editingSubject);
            ObjectDumper.Write(context2.Subject.Where(s => s.ID == Id));

            editingSubject.Description = @"Testing update";

            Console.WriteLine("After Change:");
            ObjectDumper.Write(context1.Subject.Where(s => s.ID == Id));
            ObjectDumper.Write(context2.Subject.Where(s => s.ID == Id));
        }

        [Sample(7, 5, "7-5：使用标识管理和变化跟踪服务来提交变化")]
        public void LifecycleTest_7_5()
        {
            LinqBooksDataContext context1 = new LinqBooksDataContext();
            LinqBooksDataContext context2 = new LinqBooksDataContext();
            context1.Log = Console.Out;
            context2.Log = Console.Out;

            Guid Id = new Guid("92f10ca6-7970-473d-9a25-1ff6cab8f682");

            Subject editingSubject = context1.Subject.Where(s => s.ID == Id).SingleOrDefault();

            Console.WriteLine("Before Change:");
            ObjectDumper.Write(editingSubject);
            ObjectDumper.Write(context2.Subject.Where(s => s.ID == Id));

            editingSubject.Description = @"Testing update";

            Console.WriteLine("After Change:");
            ObjectDumper.Write(context1.Subject.Where(s => s.ID == Id));
            ObjectDumper.Write(context2.Subject.Where(s => s.ID == Id));

            context1.SubmitChanges();

            Console.WriteLine("After Submit Changes:");
            ObjectDumper.Write(context1.Subject.Where(s => s.ID == Id));
            ObjectDumper.Write(context2.Subject.Where(s => s.ID == Id));
            LinqBooksDataContext context3 = new LinqBooksDataContext();
            ObjectDumper.Write(context3.Subject.Where(s => s.ID == Id));

            //Reset values
            editingSubject.Description = "Original Value";
            context1.SubmitChanges();
        }

        [Sample(7, 6, "7-6：在离线环境中修改记录")]
        public void DisconnectedTest_7_6()
        {
            LinqBooksDataContext context1 = new LinqBooksDataContext();
            context1.Log = Console.Out;

            /* Objects can only be attached to a single context at any given time. 
             * This is done to avoid the potential to update child objects erroneously. 
             * For the purposes of this example, we purposefully set up context1 up so that
             * it wouldn’t track the changes by setting the ObjectTrackingEnabled to false.
             * Attempting to attach an object to a second context will result in a NotSupportedException.  */
            context1.ObjectTrackingEnabled = false;

            Subject cachedSubject = context1.Subject.First();
            Console.WriteLine("Starting name: {0}", cachedSubject.Name);

            // In a real application, this object would now be cached or remoted via a web service
            // Use second context to simulate disconnected environment

            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                UpdateSubject(cachedSubject);
                Console.WriteLine("Updated name: {0}", cachedSubject.Name);
                //Rollback the change after running the demo
            }
        }
        public void UpdateSubject(Subject cachedSubject)
        {
            LinqBooksDataContext context = new LinqBooksDataContext();
            context.Log = Console.Out;
            context.Subject.Attach(cachedSubject);
            cachedSubject.Name = @"Testing update";

            context.SubmitChanges();
        }

        [Sample(7, 7, "7-7：更新已经发生变化的离线对象")]
        public void SoaTest_7_7()
        {
            LinqBooksDataContext context1 = new LinqBooksDataContext();
            context1.Log = Console.Out;

            Guid Id = new Guid("92f10ca6-7970-473d-9a25-1ff6cab8f682");

            Subject existingSubject = context1.Subject.Where(s => s.ID == Id).SingleOrDefault();
            Console.WriteLine("Starting name: {0}", existingSubject.Name);

            Subject changingSubject = new Subject { ID = existingSubject.ID };
            changingSubject.Name = @"Testing update";

            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                //Apply the changes through a mimiced service
                Subject.UpdateSubject(changingSubject);

                //Rollback the change after running the demo
            }
        }
    }
}
