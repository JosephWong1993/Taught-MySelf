using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfAppAllCode
{
	class MainWindow : Window
	{
		//	我们的UI元素
		private Button BtnExitApp = new Button();

		public MainWindow(string windowTitle, int height, int width)
		{
			//	配置按钮并设置子控件
			BtnExitApp.Click += new RoutedEventHandler(BtnExitApp_Clicked);
			BtnExitApp.Content = "Exit Application";
			BtnExitApp.Height = 25;
			BtnExitApp.Width = 100;

			//	讲窗体的内容设置为一个按钮
			this.Content = BtnExitApp;

			//	配置窗体
			this.Title = windowTitle;
			this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			this.Height = height;
			this.Width = width;

			this.Closing += MainWindow_Closing;
			this.Closed += MainWindow_Closed;
			this.MouseMove += MainWindow_MouseMove;
			this.KeyDown += MainWindow_KeyDown;
		}

		private void MainWindow_KeyDown(object sender, KeyEventArgs e)
		{
			//	显示按钮上的按键
			BtnExitApp.Content = e.Key.ToString();
		}

		private void MainWindow_MouseMove(object sender, MouseEventArgs e)
		{
			//	讲窗口的标题设置为鼠标当前的(x,y);
			this.Title = e.GetPosition(this).ToString();
		}

		private void MainWindow_Closing(object sender, CancelEventArgs e)
		{
			//	用户是否真的希望关闭这个窗口
			string msg = "Do you want yo close without saving?";
			MessageBoxResult result = MessageBox.Show(
				msg,
				"My App",
				MessageBoxButton.YesNo,
				MessageBoxImage.Warning);
			if (result == MessageBoxResult.No)
			{
				//	如果用户不希望关闭,则取消关闭
				e.Cancel = true;
			}
		}

		private void MainWindow_Closed(object sender, EventArgs e)
		{
			MessageBox.Show("See ya!");
		}


		private void BtnExitApp_Clicked(object sender, RoutedEventArgs e)
		{
			if ((bool)Application.Current.Properties["GodMode"])
			{
				MessageBox.Show("Cheater!");
			}

			//	关闭窗体
			this.Close();
		}
	}
}
