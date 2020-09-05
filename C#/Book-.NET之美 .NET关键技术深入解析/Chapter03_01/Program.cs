using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_01
{
	public delegate void GreetingDelegate(string name);

	class Program
	{
		static void Main(string[] args)
		{
			GreetingDelegate delegate1 = new GreetingDelegate(EnglishGreeting);
			delegate1 += ChineseGreeting;

			GreetPeople("Jimmy Zhang", delegate1);
			Console.WriteLine();

			delegate1 -= EnglishGreeting;
			GreetPeople("Jimmy Zhang", delegate1);
			Console.ReadKey();
		}

		public static void GreetPeople(string name, GreetingDelegate MakeGreeting)
		{
			//	做某些额外的事情,比如初始化之类,此处略
			MakeGreeting(name);
		}

		public static void EnglishGreeting(string name)
		{
			Console.WriteLine("Morning, " + name);
		}

		public static void ChineseGreeting(string name)
		{
			Console.WriteLine("早上好, " + name);
		}
	}
}
