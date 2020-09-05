namespace MyEBookReader
{
    partial class FormMyEBookReader
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBook = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnGetStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(12, 12);
            this.txtBook.Multiline = true;
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(260, 208);
            this.txtBook.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(12, 226);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "btnDownload";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnGetStats
            // 
            this.btnGetStats.Location = new System.Drawing.Point(172, 226);
            this.btnGetStats.Name = "btnGetStats";
            this.btnGetStats.Size = new System.Drawing.Size(100, 23);
            this.btnGetStats.TabIndex = 2;
            this.btnGetStats.Text = "btnGetStats";
            this.btnGetStats.UseVisualStyleBackColor = true;
            this.btnGetStats.Click += new System.EventHandler(this.btnGetStats_Click);
            // 
            // FormMyEBookReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGetStats);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtBook);
            this.Name = "FormMyEBookReader";
            this.Text = "FormMyEBookReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnGetStats;
    }
}

