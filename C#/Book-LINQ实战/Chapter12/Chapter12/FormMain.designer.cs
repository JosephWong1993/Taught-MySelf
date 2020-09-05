namespace Chapter12
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewSample = new System.Windows.Forms.TreeView();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbListing = new System.Windows.Forms.Label();
            this.lbChapter = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lbDescriptionTitle = new System.Windows.Forms.Label();
            this.lbListingTitle = new System.Windows.Forms.Label();
            this.lbChapterTitle = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewSample);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Panel2.Controls.Add(this.lbDescription);
            this.splitContainer1.Panel2.Controls.Add(this.lbListing);
            this.splitContainer1.Panel2.Controls.Add(this.lbChapter);
            this.splitContainer1.Panel2.Controls.Add(this.btnRun);
            this.splitContainer1.Panel2.Controls.Add(this.lbDescriptionTitle);
            this.splitContainer1.Panel2.Controls.Add(this.lbListingTitle);
            this.splitContainer1.Panel2.Controls.Add(this.lbChapterTitle);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 562);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewSample
            // 
            this.treeViewSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSample.Location = new System.Drawing.Point(0, 0);
            this.treeViewSample.Name = "treeViewSample";
            this.treeViewSample.Size = new System.Drawing.Size(400, 562);
            this.treeViewSample.TabIndex = 0;
            this.treeViewSample.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSample_AfterSelect);
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(120, 70);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(19, 14);
            this.lbDescription.TabIndex = 7;
            this.lbDescription.Text = "   ";
            // 
            // lbListing
            // 
            this.lbListing.AutoSize = true;
            this.lbListing.Location = new System.Drawing.Point(120, 40);
            this.lbListing.Name = "lbListing";
            this.lbListing.Size = new System.Drawing.Size(19, 14);
            this.lbListing.TabIndex = 6;
            this.lbListing.Text = "   ";
            // 
            // lbChapter
            // 
            this.lbChapter.AutoSize = true;
            this.lbChapter.Location = new System.Drawing.Point(120, 10);
            this.lbChapter.Name = "lbChapter";
            this.lbChapter.Size = new System.Drawing.Size(19, 14);
            this.lbChapter.TabIndex = 5;
            this.lbChapter.Text = "   ";
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Location = new System.Drawing.Point(0, 136);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(680, 426);
            this.txtOutput.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(30, 100);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 30);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lbDescriptionTitle
            // 
            this.lbDescriptionTitle.AutoSize = true;
            this.lbDescriptionTitle.Location = new System.Drawing.Point(30, 70);
            this.lbDescriptionTitle.Name = "lbDescriptionTitle";
            this.lbDescriptionTitle.Size = new System.Drawing.Size(43, 14);
            this.lbDescriptionTitle.TabIndex = 2;
            this.lbDescriptionTitle.Text = "描述：";
            // 
            // lbListingTitle
            // 
            this.lbListingTitle.AutoSize = true;
            this.lbListingTitle.Location = new System.Drawing.Point(30, 40);
            this.lbListingTitle.Name = "lbListingTitle";
            this.lbListingTitle.Size = new System.Drawing.Size(67, 14);
            this.lbListingTitle.TabIndex = 1;
            this.lbListingTitle.Text = "代码清单：";
            // 
            // lbChapterTitle
            // 
            this.lbChapterTitle.AutoSize = true;
            this.lbChapterTitle.Location = new System.Drawing.Point(30, 10);
            this.lbChapterTitle.Name = "lbChapterTitle";
            this.lbChapterTitle.Size = new System.Drawing.Size(43, 14);
            this.lbChapterTitle.TabIndex = 0;
            this.lbChapterTitle.Text = "章节：";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewSample;
        private System.Windows.Forms.Label lbChapterTitle;
        private System.Windows.Forms.Label lbDescriptionTitle;
        private System.Windows.Forms.Label lbListingTitle;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbListing;
        private System.Windows.Forms.Label lbChapter;

    }
}