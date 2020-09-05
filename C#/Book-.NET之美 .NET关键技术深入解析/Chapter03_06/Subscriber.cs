using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter03_06
{
	class Subscriber1
	{
		public void OnEvent(object sender, EventArgs e)
		{
			Thread.Sleep(TimeSpan.FromSeconds(3));
			Console.WriteLine("Waited for 3 secondsm, subscriber1 invoked!");
		}
	}
	class Subscriber2
	{
		public void OnEvent(object sender, EventArgs e)
		{
			Console.WriteLine("Subscriber2 immediately Invoked!");
		}
	}
	class Subscriber3
	{
		public void OnEvent(object sender, EventArgs e)
		{
			Thread.Sleep(TimeSpan.FromSeconds(2));
			Console.WriteLine("Waited for 2 seconds, subscriber2 invoked!");
		}
	}
}
