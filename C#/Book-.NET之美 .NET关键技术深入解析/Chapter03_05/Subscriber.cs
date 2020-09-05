using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_05
{
	class Subscriber1
	{
		public string OnNumberChanged()
		{
			return "Subscriber1";
		}

		public string OnNumberChanged(int num)
		{
			Console.WriteLine("Subscriber1 invoked, number: {0}", num);
			return "[Subscriber1 returned]";
		}
		public void OnEvent(object sender, EventArgs e)
		{
			Console.WriteLine("Subscriber1 Invoked!");
		}
	}
	class Subscriber2
	{
		public string OnNumberChanged()
		{
			return "Subscriber2";
		}
		public string OnNumberChanged(int num)
		{
			Console.WriteLine("Subscriber2 invoked, number: {0}", num);
			return "[Subscriber2 returned]";
		}
		public void OnEvent(object sender, EventArgs e)
		{
			throw new Exception("Subscriber2 Failed");
		}
	}
	class Subscriber3
	{
		public string OnNumberChanged()
		{
			return "Subscriber3";
		}

		public string OnNumberChanged(int num)
		{
			Console.WriteLine("Subscriber3 invoked, number: {0}", num);
			return "[Subscriber3 returned]";
		}
		public void OnEvent(object sender, EventArgs e)
		{
			Console.WriteLine("Subscriber3 Invoked!");
		}
	}
}
