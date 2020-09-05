using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithCSharpAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCallMethod_Click(object sender, EventArgs e)
        {
            this.Text = await DoWorkAsync();
        }

        private async void btnVoidMethodCall_Click(object sender, EventArgs e)
        {
            await MethodReturningVoidAsunc();
            MessageBox.Show("Done");
        }

        private async void btnMutliAwaits_Click(object sender, EventArgs e)
        {
            await Task.Run(() => { Thread.Sleep(2000); });
            MessageBox.Show("Done with first task!");

            await Task.Run(() => { Thread.Sleep(2000); });
            MessageBox.Show("Done with second task!");

            await Task.Run(() => { Thread.Sleep(2000); });
            MessageBox.Show("Done with third task!");
        }

        //  对下面的代码进行走查
        private async Task<string> DoWorkAsync()
        {
            return await Task.Run(
                () =>
                {
                    Thread.Sleep(10000);
                    return "Done with work!";
                });
        }

        private async Task MethodReturningVoidAsunc()
        {
            await Task.Run(
                () =>
                {
                    //  进行一些处理。。。
                    Thread.Sleep(4000);
                });
        }
    }
}
