using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_04
{
	//	显示器
	public class Display
	{
		//	静态方法
		public static void ShowMsg(Object sender, Heater.BoiledEventArgs e)
		{
			Heater heater = (Heater)sender;
			Console.WriteLine("Display: {0} - {1}", heater.area, heater.type);
			Console.WriteLine("Display: 水已烧开, 当前温度:{0}度:", e.temperature);
			Console.WriteLine();
		}
	}
}
