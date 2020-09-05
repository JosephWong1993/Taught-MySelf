using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckInventoryWorkflowLib;

namespace WorkflowLibraryClient
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("**** Inventory Look up ****");

			//	获取用户偏好
			Console.Write("Enter Color: ");
			string color = Console.ReadLine();
			Console.Write("Enter Make: ");
			string make = Console.ReadLine();

			//	包装工作流要用的数据
			Dictionary<string, object> wfArgs = new Dictionary<string, object>()
			{
				{"RequestedColor",color },
				{"RequestedMake",make }
			};

			try
			{
				//	向工作流发送数据 
				IDictionary<string, object> outputArgs =
					WorkflowInvoker.Invoke(new CheckInventory(), wfArgs);

				//	打印输出的消息
				Console.WriteLine(outputArgs["FormattedResponse"]);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadLine();
		}
	}
}
