using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using CommonSnappableTypes;

namespace MyExtendableApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void snapInModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  允许用户选择一个程序集加载
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.Contains("CommonSnappableTypes"))
                    MessageBox.Show("CommonSnappableTypes has no snap-ins!");
                else if (!LoadExternalModule(dlg.FileName))
                    MessageBox.Show("Nothing omplements IAppFunctionality!");
            }
        }

        private bool LoadExternalModule(string path)
        {
            bool foundSnapIn = false;
            Assembly theSnapInAsm = null;
            try
            {
                //  动态加载选中的程序集
                theSnapInAsm = Assembly.LoadFrom(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return foundSnapIn;
            }

            //  得到程序集中所有的IAppFunctionality兼容的类
            var theClassTypes = from t in theSnapInAsm.GetTypes()
                                where t.IsClass
                                && (t.GetInterface("IAppFunctionality") != null)
                                select t;
            //  创建对象对调用DoIt()方法
            foreach (Type t in theClassTypes)
            {
                foundSnapIn = true;
                //  使用晚期绑定建立类型
                IAppFunctionality itfApp = (IAppFunctionality)theSnapInAsm.CreateInstance(t.FullName, true);
                itfApp.DoIt();
                lstLoadedSnapIns.Items.Add(t.FullName);
                DisplayCompanyData(t);
            }
            return foundSnapIn;
        }

        private void DisplayCompanyData(Type t)
        {
            //  获取[]CompanyInfo数据
            var company = from ci in t.GetCustomAttributes(false)
                          where (ci.GetType() == typeof(CompanyInfoAttribute))
                          select ci;
            foreach (CompanyInfoAttribute c in company)
            {
                MessageBox.Show(c.CompanyUrl, string.Format("More info about {0} can be found at", c.CompanyName));
            }
        }
    }
}
