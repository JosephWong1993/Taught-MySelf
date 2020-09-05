using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_01
{
	public class Book : IComparable
	{
		private int price;
		private string title;

		public Book() { }
		public Book(int price, string title)
		{
			this.price = price;
			this.title = title;
		}
		public int Price { get { return this.price; } }
		public string Title { get { return this.title; } }

		public int CompareTo(object obj)
		{
			Book book2 = (Book)obj;
			return this.Price.CompareTo(book2.price);
		}
	}
}
