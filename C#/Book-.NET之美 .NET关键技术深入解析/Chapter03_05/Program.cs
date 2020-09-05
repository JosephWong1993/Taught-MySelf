using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_05
{
	class Program
	{
		//	触发某个事件,以列表形式返回所有方法的返回值
		public static object[] FireEvent(Delegate del, params object[] args)
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

		static void Main(string[] args)
		{
			Publisher pub = new Publisher();
			Subscriber1 sub1 = new Subscriber1();
			Subscriber2 sub2 = new Subscriber2();
			Subscriber3 sub3 = new Subscriber3();

			//pub.NumberChanged += new DemoEventHandler(sub1.OnNumberChanged);
			//pub.NumberChanged += new DemoEventHandler(sub2.OnNumberChanged);
			//pub.NumberChanged += new DemoEventHandler(sub3.OnNumberChanged);
			//List<string> list = pub.DoSomething();
			//foreach (string str in list)
			//{
			//	Console.WriteLine(str);
			//}

			pub.MyEvent += new EventHandler(sub1.OnEvent);
			pub.MyEvent += new EventHandler(sub2.OnEvent);
			pub.MyEvent += new EventHandler(sub3.OnEvent);
			pub.DoSomething();

			Console.ReadKey();
		}
	}
}
