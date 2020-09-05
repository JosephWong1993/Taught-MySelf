using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;
using System.Windows.Markup;

namespace MyXamlPad
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //应用程序主窗口加载的时候
            //把一些基本的XMAL文本放到文本框内
            if (File.Exists(System.Environment.CurrentDirectory + "\\YourXaml.xaml"))
            {
                txtXamlData.Text = File.ReadAllText("YourXaml.xaml");
            }
            else
            {
                txtXamlData.Text =
                    "<Window xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\n"
                    + "  xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"\n"
                    + " Height =\"400\" Width =\"500\" WindowStartupLocation=\"CenterScreen\">\n"
                    + "<StackPanel>\n"
                    + "</StackPanel>\n"
                    + "</Window>";
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // 把文本框中的数据写入本地的*.xmal文件中
            File.WriteAllText("YourXaml.xaml", txtXamlData.Text);
            Application.Current.Shutdown();
        }

        private void btnViewXaml_Click(object sender, RoutedEventArgs e)
        {
            // 把文本框中的数据写入本地的*.xmal文件中
            File.WriteAllText("YourXaml.xaml", txtXamlData.Text);

            // 这个Window XAML会被动态解析
            Window myWindow = null;
            // 打开本地*.xaml文件
            try
            {
                using (Stream sr = File.Open("YourXaml.xaml", FileMode.Open))
                {
                    // 把XAML连接到Window对象
                    myWindow = (Window)XamlReader.Load(sr);

                    // 将窗口显示为对话框并清除掉
                    myWindow.ShowDialog();
                    myWindow.Close();
                    myWindow = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
