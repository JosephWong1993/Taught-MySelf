using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Chapter06to08.BusinessLogic.SampleHarness;
using Chapter06to08.BusinessLogic.Chapter06;
using System.IO;
using Chapter06to08.BusinessLogic.Chapter07;
using Chapter06to08.BusinessLogic.Chapter08;

namespace Chapter06to08
{
    public partial class FormMain : Form
    {
        SampleClass currentClass;
        SampleItem currentSample;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<SampleClass> sampleList = GetSamples();
            foreach (SampleClass sampleClass in sampleList)
            {
                TreeNode classNode = this.treeViewSample.Nodes.Add(sampleClass.Title);
                classNode.Tag = sampleClass;
                foreach (SampleItem item in sampleClass)
                {
                    TreeNode itemNode = classNode.Nodes.Add(item.Description);
                    itemNode.Tag = item;
                }
            }
        }

        private void treeViewSample_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = this.treeViewSample.SelectedNode;
            if (selectedNode.Parent == null)
            {
                InitUI();
                return;
            }

            currentSample = selectedNode.Tag as SampleItem;
            if (currentSample == null)
            {
                InitUI();
                return;
            }

            currentClass = selectedNode.Parent.Tag as SampleClass;
            this.lbChapter.Text = currentSample.Chapter.ToString();
            this.lbListing.Text = currentSample.ListingNumber.ToString();
            this.lbDescription.Text = currentSample.Description;
            this.btnRun.Enabled = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.txtOutput.Text = string.Empty;
            if (currentSample != null)
            {
                RunSample(currentClass, currentSample);
            }
        }

        private List<SampleClass> GetSamples()
        {
            List<SampleClass> sampleList = new List<SampleClass>();
            sampleList.Add(new Ch6Samples());
            sampleList.Add(new Ch7Samples());
            sampleList.Add(new Ch8Samples());
            return sampleList;
        }

        private void RunSample(SampleClass currentClass, SampleItem currentSample)
        {
            if (currentSample == null)
            {
                return;
            }

            base.UseWaitCursor = true;

            TextWriter output = Console.Out;
            StreamWriter newOut = currentClass.OutputStreamWriter;
            Console.SetOut(newOut);
            MemoryStream baseStream = newOut.BaseStream as MemoryStream;
            baseStream.SetLength(0);

            try
            {
                currentSample.Method.Invoke(currentClass, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
            newOut.Flush();

            Console.SetOut(output);
            txtOutput.Text = txtOutput.Text + newOut.Encoding.GetString(baseStream.ToArray());
            
            base.UseWaitCursor = false;
        }

        private void InitUI()
        {
            this.lbChapter.Text
                    = this.lbListing.Text
                    = this.lbDescription.Text
                    = string.Empty;
            this.btnRun.Enabled = false;
        }
    }
}