//	不使用XAML写的一个简单的WPF应用程序
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppAllCode
{
	//	在这第一个示例中，为了表示应用程序本身和其主窗口，我们定义了一个简单的类
	class Program : Application
	{
		[STAThread]
		static void Main(string[] args)
		{
			//	处理Startup和Exit事件，随后运行应用程序
			Program app = new Program();
			//app.Startup += AppStartUp;
			//app.Exit += AppExit;
			app.Startup += new StartupEventHandler(AppStartUp);
			app.Exit += new ExitEventHandler(AppExit);
			app.Run();  //	触发Startup事件
		}

		static void AppStartUp(object sender, StartupEventArgs e)
		{
			//	创建一个Window对象，同时设置一些基本属性
			//Window mainWindow = new Window();
			//mainWindow.Title = "My First WPF App!";
			//mainWindow.Height = 200;
			//mainWindow.Width = 300;
			//mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			//mainWindow.Show();

			//	检查传入的命令行参数来看是否它们指定了/GODMODE标识
			Application.Current.Properties["GodMode"] = false;
			foreach (string arg in e.Args)
			{
				if (arg.ToLower() == "/godmode")
				{
					Application.Current.Properties["GodMode"] = true;
					break;
				}
			}

			//	创建一个MainWindow对象
			MainWindow wnd = new MainWindow("My better WPF App!", 200, 300);
			wnd.Show();
		}

		static void AppExit(object sender, ExitEventArgs e)
		{
			MessageBox.Show("App has exited");
		}
	}
}
