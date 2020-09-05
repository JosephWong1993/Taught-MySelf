using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO;


namespace DataParallelismWithForEach
{
    public partial class MainForm : Form
    {
        //  新的Form级别的变量
        private CancellationTokenSource cancelToken = new CancellationTokenSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProcessImages_Click(object sender, EventArgs e)
        {
            //ProcessFiles();
            Task.Factory.StartNew(() =>
            {
                ProcessFiles();
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //  停止所有工作者线程
            cancelToken.Cancel();
        }

        private void ProcessFiles()
        {
            //  加载所有*.jpg文件,并为修改后的数据新建一个文件夹
            string[] files = Directory.GetFiles(@"C:\Users\Public\Pictures\Sample Pictures",
                "*.jpg",
                SearchOption.AllDirectories);
            string newDir = @"F:\ModifiedPictures";
            if (!Directory.Exists(newDir))
            {
                Directory.CreateDirectory(newDir);
            }

            //  以阻塞方式处理图像数据
            //foreach (string currentFile in files)
            //{
            //    string filename = Path.GetFileName(currentFile);
            //    using (Bitmap bitmap = new Bitmap(currentFile))
            //    {
            //        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            //        bitmap.Save(Path.Combine(newDir, filename));

            //        //  打印处理当前图像的线程ID
            //        this.Text = string.Format("Processing {0} on thread {1}", filename,
            //            Thread.CurrentThread.ManagedThreadId);
            //    }
            //}

            //  使用ParalleOptions实例保存CancellationToken
            ParallelOptions parOpts = new ParallelOptions();
            parOpts.CancellationToken = cancelToken.Token;
            parOpts.MaxDegreeOfParallelism = Environment.ProcessorCount;
            try
            {
                Parallel.ForEach(files, parOpts, currentFile =>
                {
                    string filename = Path.GetFileName(currentFile);
                    using (Bitmap bitmap = new Bitmap(currentFile))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(newDir, filename));

                        //  呃!不能再用了@
                        //this.Text = string.Format("Processing {0} on thread {1}", filename,
                        //    Thread.CurrentThread.ManagedThreadId);


                        //  在Form对象上调用.允许次线程以线程安全的方式访问控件
                        this.Invoke((Action)delegate
                        {
                            this.Text = string.Format("Processing {0} on thread {1}", filename,
                                Thread.CurrentThread.ManagedThreadId);
                        });
                    }
                });
            }
            catch (OperationCanceledException ex)
            {
                this.Invoke((Action)delegate
                {
                    this.Text = ex.Message;
                });
            }
        }


    }
}
