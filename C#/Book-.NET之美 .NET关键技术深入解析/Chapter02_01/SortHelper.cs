using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_01
{
	public class SortHelper
	{
		public void BubbleSort<T>(T[] array) where T : IComparable
		{
			int length = array.Length;
			for (int i = 0; i <= length - 2; i++)
			{
				for (int j = length - 1; j >= 1; j--)
				{
					//	对两个元素进行交换
					if (array[j].CompareTo(array[j - 1]) < 0)
					{
						T temp = array[j];
						array[j] = array[j - 1];
						array[j - 1] = temp;
					}
				}
			}
		}
	}
}
