using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Reflection;
using System.Configuration;
using System.Data.Linq;

namespace Chapter06to08.BusinessLogic
{
    public partial class LinqBooksDataContext
    {
        [Function(Name = "dbo.fnBookCountForPublisher", IsComposable = true)]
        public int? fnBookCountForPublisher1(
            [Parameter(Name = "PublisherId")] Guid? publisherId)
        {
            return (int?)(this.ExecuteMethodCall(
                this,
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                publisherId).ReturnValue);
        }

        [Function(Name = "dbo.GetBook")]
        public ISingleResult<Book> GetBook_Custom([Parameter(Name = "BookId", DbType = "UniqueIdentifier")] System.Nullable<System.Guid> bookId, [Parameter(Name = "UserName", DbType = "NVarChar(50)")] string userName)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), bookId, userName);
            return ((ISingleResult<Book>)(result.ReturnValue));
        }

        /// <summary>
        /// Helper method to encapsulate the context instance which calls the 
        /// <see cref="ExpensiveBooks">ExpensiveBooks compiled query</see>
        /// </summary>
        /// <param name="minimumPrice"></param>
        /// <returns>Enumerable list of Books whith a price higher than the minimumPrice</returns>
        public static IQueryable<Book>
            GetExpensiveBooks(decimal minimumPrice)
        {
            LinqBooksDataContext context = new LinqBooksDataContext(ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString);
            return ExpensiveBooks(context, minimumPrice);
        }

        /// <summary>
        /// Precompiled version of the Expensive Books query
        /// </summary>
        public static Func<LinqBooksDataContext, decimal, IQueryable<Book>> ExpensiveBooks = CompiledQuery.Compile(
            (LinqBooksDataContext context, decimal minimumPrice) =>
                    from book in context.Book
                    where book.Price >= minimumPrice
                    select book);
    }
}
