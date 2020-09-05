using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_01
{
	class Program
	{
		static void Main(string[] args)
		{
			Book[] bookArray = new Book[2];

			Book book1 = new Book(30, "HTML5解析");
			Book book2 = new Book(21, "JavaScript实战");
			bookArray[0] = book1;
			bookArray[1] = book2;

			SortHelper sorter = new SortHelper();
			sorter.BubbleSort<Book>(bookArray);
			foreach (Book b in bookArray)
			{
				Console.WriteLine("Price:{0}", b.Price);
				Console.WriteLine("Title:{0}\n", b.Title);
			}
			Console.ReadKey();
		}
	}
}
