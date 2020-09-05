using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWordPad
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetF1CommandBinding();
        }

        private void SetF1CommandBinding()
        {
            CommandBinding helpBinding = new CommandBinding(ApplicationCommands.Help);
            helpBinding.CanExecute += CanHelpExecute;
            helpBinding.Executed += HelpExecuted;
            CommandBindings.Add(helpBinding);
        }

        private void CanHelpExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //  如果要阻止命令执行，可以将CanExecute设置为false
            e.CanExecute = true;
        }

        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Look, it is not that difficult. Just type something!", "Help!");
        }

        protected void FileExit_Click(object sender, RoutedEventArgs args)
        {
            //  关闭该窗口
            this.Close();
        }

        protected void ToolsSpellingHints_Click(object sender, RoutedEventArgs args)
        {
            string spellingHints = string.Empty;

            //  获取当前位置的拼写错误
            SpellingError error = txtData.GetSpellingError(txtData.CaretIndex);
            if (error != null)
            {
                //  构建更改建议的字符串
                foreach (string s in error.Suggestions)
                {
                    spellingHints += string.Format("{0}\n", s);
                }

                //  显示建议和扩展Expander
                lblSpellingHints.Content = spellingHints;
                expanderSpelling.IsExpanded = true;
            }
        }

        protected void MouseEnterExitArea(object sender, RoutedEventArgs args)
        {
            statBarText.Text = "Exit the Application";
        }
        protected void MouseEnterToolsHintsArea(object sender, RoutedEventArgs args)
        {
            statBarText.Text = "Show Spelling Suggestions";
        }
        protected void MouseLeaveArea(object sender, RoutedEventArgs args)
        {
            statBarText.Text = "Ready";
        }

        private void OpenCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            //  创建打开文件的对话框，并且只显示XAML文件
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Text Files |*.txt";

            //  是否单机了OK按钮
            if (true == openDlg.ShowDialog())
            {
                //  加载所选文件的所有文本
                string dataFromFile = File.ReadAllText(openDlg.FileName);

                //  在TextBox中显示字符串
                txtData.Text = dataFromFile;
            }
        }

        private void SaveCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Text Files |*.txt";

            //  是否单击了OK按钮
            if (true == saveDlg.ShowDialog())
            {
                //  将TextBox中的数据保存到命名的文件中
                File.WriteAllText(saveDlg.FileName, txtData.Text);
            }
        }
    }
}
