using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_04
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] phones = { "029-88401100", "029-88500321" };
			Address a = new Address("陕西", "西安", "710068", phones);
			Console.WriteLine(a.Phones[0]);
			phones[0] = "029-XXXXXXXX";
			Console.WriteLine(a.Phones[0]);

			Console.ReadKey();
		}
	}
}
