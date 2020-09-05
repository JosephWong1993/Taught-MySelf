using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_05
{
	//	定义委托
	//public delegate string GeneralEventHandler();
	public delegate string DemoEventHandler(int num);

	public class Publisher
	{
		//	让事件只允许一个客户订阅
		//private GeneralEventHandler numberChanged;
		//public event GeneralEventHandler NumberChanged
		//{
		//	add
		//	{
		//		numberChanged = value;
		//	}
		//	remove
		//	{
		//		numberChanged -= value;
		//	}
		//} //	声明一个事件
		//public void DoSomething()
		//{
		//	//	触发事件
		//	if (numberChanged != null)
		//	{
		//		string rtn = numberChanged();
		//		Console.WriteLine(rtn); //	打印返回的字符串
		//	}
		//}

		//	获得多个返回值与异常处理
		//public event DemoEventHandler NumberChanged;
		//public List<string> DoSomething()
		//{
		//	List<string> strList = new List<string>();
		//	if (NumberChanged == null) return strList;

		//	//	获得委托数组
		//	Delegate[] delArray = NumberChanged.GetInvocationList();
		//	foreach (Delegate del in delArray)
		//	{
		//		//	进行一个向下转换
		//		DemoEventHandler method = (DemoEventHandler)del;
		//		strList.Add(method(100));   //	调用方法并获取用返回值
		//	}
		//	return strList;
		//}
		public event EventHandler MyEvent;
		public void DoSomething()
		{
			Program.FireEvent(MyEvent, this, EventArgs.Empty);
		}
	}
}
