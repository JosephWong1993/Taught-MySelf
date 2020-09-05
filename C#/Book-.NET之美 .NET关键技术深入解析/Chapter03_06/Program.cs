using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_06
{
	class Program
	{
		static void Main(string[] args)
		{
			Publisher pub = new Publisher();
			Subscriber1 sub1 = new Subscriber1();
			Subscriber2 sub2 = new Subscriber2();
			Subscriber3 sub3 = new Subscriber3();

			pub.MyEvent += new EventHandler(sub1.OnEvent);
			pub.MyEvent += new EventHandler(sub2.OnEvent);
			pub.MyEvent += new EventHandler(sub3.OnEvent);
			pub.DoSomething();

			Console.WriteLine("\nControl back to client!");
			Console.ReadKey();
		}

		public static object[] FireEvent(Delegate del,params object[] args)
		{
			List<object> objList = new List<object>();
			if (del != null)
			{
				Delegate[] delArray = del.GetInvocationList();
				foreach (Delegate method in delArray)
				{
					try
					{
						//	使用DynamicInvoke方法触发事件
						object obj = method.DynamicInvoke(args);
						if (obj != null)
						{
							objList.Add(obj);
						}
					}
					catch { }
				}
			}
			return objList.ToArray();
		}
	}
}
