using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Threading;

namespace FirstWorkflowExampleApp
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Welcome to this amazing WF application ****");

			//	获取用户输入的数据,传递给工作流
			Console.Write("Please enter the data to pass the workflow:");
			string wfData = Console.ReadLine();

			//	将数据存入字典中
			Dictionary<string, object> wfArgs = new Dictionary<string, object>();
			wfArgs.Add("MessageToShow", wfData);

			////	传递给工作流
			//Activity workflow1 = new Workflow1();
			//WorkflowInvoker.Invoke(workflow1, wfArgs);

			//	通知主线程进行等待
			AutoResetEvent waitHandle = new AutoResetEvent(false);

			//	传递给工作流
			WorkflowApplication app = new WorkflowApplication(new Workflow1(), wfArgs);

			//	将事件与app挂钩.当工作流结束时,通知其他线程,并打印一条信息
			app.Completed = (completedArgs =>
				{
					waitHandle.Set();
					Console.WriteLine("The workflow is done!");
				});

			//	开启工作流
			app.Run();

			//	在工作流结束之前一直等待
			waitHandle.WaitOne();

			Console.WriteLine("Thanks for playing");

			Console.ReadKey();
		}
	}
}
