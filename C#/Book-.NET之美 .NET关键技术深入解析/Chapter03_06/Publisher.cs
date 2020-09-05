using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_06
{
	class Publisher
	{
		public event EventHandler MyEvent;
		public void DoSomething()
		{
			//	做某些其他的事情
			Console.WriteLine("DoSomething invoked!");
			Program.FireEvent(MyEvent, this, EventArgs.Empty);
		}
	}
}
