using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_04
{
	public class Alarm
	{
		public void MakeAlert(Object sender, Heater.BoiledEventArgs e)
		{
			Heater heater = (Heater)sender;
			//	访问sender中的公共字段
			Console.WriteLine("Alarm: {0} - {1}", heater.area, heater.type);
			Console.WriteLine("Alarm: 嘀嘀嘀, 水已经{0}度了", e.temperature);
			Console.WriteLine();
		}
	}
}
