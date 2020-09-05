using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_02
{
	class Program
	{
		private static void EnglishGreeting(string name)
		{
			Console.WriteLine("Morning, " + name);
		}

		private static void ChineseGreeting(string name)
		{
			Console.WriteLine("早上好, " + name);
		}

		static void Main(string[] args)
		{
			GreetingManager gm = new GreetingManager();
			gm.MakeGreet += EnglishGreeting;
			gm.MakeGreet += ChineseGreeting;
			gm.GreetPeople("Jimmy Zhang");
			Console.ReadKey();
		}
	}
}
