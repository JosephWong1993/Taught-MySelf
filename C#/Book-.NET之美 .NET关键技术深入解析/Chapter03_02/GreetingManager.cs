using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_02
{
	public delegate void GreetingDelegate(string name);

	public class GreetingManager
	{
		public event GreetingDelegate MakeGreet;
		public void GreetPeople(string name)
		{
			//	做某些额外的事情,比如初始化之类,此处略
			if (MakeGreet != null)
			{
				MakeGreet(name);
			}
		}
	}
}
