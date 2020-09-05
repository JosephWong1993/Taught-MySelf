using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_04
{
	class Program
	{
		static void Main(string[] args)
		{
			Heater heater = new Heater();
			Alarm alarm = new Alarm();
			heater.Boiled += alarm.MakeAlert;    //	注册方法
			heater.Boiled += (new Alarm()).MakeAlert;    //为匿名对象注册方法
			heater.Boiled += Display.ShowMsg;    //	注册静态方法
			heater.BoilWater();

			Console.ReadKey();
		}
	}
}
