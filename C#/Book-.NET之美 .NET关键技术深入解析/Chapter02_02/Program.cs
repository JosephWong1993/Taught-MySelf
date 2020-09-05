using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter02_02
{
	class Program
	{
		const int ListSize = 500000;

		static void Main(string[] args)
		{
			UseArrayList();
			UseGenericList();
			Console.ReadKey();
		}

		private static void UseArrayList()
		{
			ArrayList list = new ArrayList();

			long startTicks = DateTime.Now.Ticks;
			for (int i = 0; i < ListSize; i++)
			{
				list.Add(i);
			}
			for (int i = 0; i < ListSize; i++)
			{
				int value = (int)list[i];
			}
			long endTicks = DateTime.Now.Ticks;
			Console.WriteLine("使用ArrayList,耗时: {0} ticks", endTicks - startTicks);
		}

		private static void UseGenericList()
		{
			List<int> list = new List<int>();

			long startTicks = DateTime.Now.Ticks;
			for (int i = 0; i < ListSize; i++)
			{
				list.Add(i);
			}
			for (int i = 0; i < ListSize; i++)
			{
				int value = (int)list[i];
			}
			long endTicks = DateTime.Now.Ticks;
			Console.WriteLine("List<int>,耗时: {0} ticks", endTicks - startTicks);
		}
	}
}
