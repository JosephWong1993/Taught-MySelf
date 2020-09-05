using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAllXaml
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //  记住,该方法定义在自动生成的MainWindow.g.cs文件中
            InitializeComponent();
        }

        private void btnExitApp_Clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}