using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PLINQDataProcessingWithCancellation
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancelToken = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            //  开始一个新的任务来处理整数
            Task.Factory.StartNew(() =>
            {
                ProcessIntData();
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelToken.Cancel();
        }

        private void ProcessIntData()
        {
            //  获得一个非常大的整数数组
            int[] source = Enumerable.Range(1, 10000000).ToArray();

            //  找到num%3==0为true的数字，降序返回
            int[] modThreeIsZero = null;
            try
            {
                modThreeIsZero = (
                    from num in source.AsParallel().WithCancellation(cancelToken.Token)
                    where num % 3 == 0
                    orderby num descending
                    select num).ToArray();
                MessageBox.Show(
                string.Format("Found {0} numbers that match query!", modThreeIsZero.Count()));
            }
            catch (OperationCanceledException exc)
            {
                this.Invoke(new Action(
                    () =>
                    {
                        this.Text = exc.Message;
                    }));
            }
        }
    }
}
