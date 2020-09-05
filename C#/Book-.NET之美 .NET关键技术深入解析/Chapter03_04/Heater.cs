using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_04
{
	public class Heater
	{
		private int temperature;
		public string type = "RealFire 001";    //	添加型号作为演示
		public string area = "China Xian";  //	添加产地作为演示

		//	声明委托
		public delegate void BoiledEventHandler(Object sender, BoiledEventArgs e);
		public event BoiledEventHandler Boiled; //	声明事件

		//	定义BoiledEventArgs类,传递给Observer所感兴趣的信息
		public class BoiledEventArgs : EventArgs
		{
			public readonly int temperature;
			public BoiledEventArgs(int temperature)
			{
				this.temperature = temperature;
			}
		}

		protected virtual void OnBoiled(BoiledEventArgs e)
		{
			Boiled?.Invoke(this, e);    //	调用所有注册对象的方法
		}

		//	烧水
		public void BoilWater()
		{
			for (int i = 0; i <= 100; i++)
			{
				temperature = i;

				if (temperature > 95)
				{
					//	建立BoiedEventArgs对象
					BoiledEventArgs e = new BoiledEventArgs(temperature);
					OnBoiled(e); //	调用OnBoiled方法
				}
			}
		}
	}
}
