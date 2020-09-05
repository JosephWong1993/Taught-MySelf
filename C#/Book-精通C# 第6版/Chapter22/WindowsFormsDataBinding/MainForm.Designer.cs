namespace WindowsFormsDataBinding
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
      this.carInventoryGridView = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnRemoveRow = new System.Windows.Forms.Button();
      this.txtCarToRemove = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnDisplayMakes = new System.Windows.Forms.Button();
      this.txtMakeToView = new System.Windows.Forms.TextBox();
      this.btnChangeMakes = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.dataGridYugosView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridYugosView)).BeginInit();
      this.SuspendLayout();
      // 
      // carInventoryGridView
      // 
      this.carInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.carInventoryGridView.Location = new System.Drawing.Point(12, 33);
      this.carInventoryGridView.Name = "carInventoryGridView";
      this.carInventoryGridView.RowTemplate.Height = 23;
      this.carInventoryGridView.Size = new System.Drawing.Size(560, 191);
      this.carInventoryGridView.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(179, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "Here is what we have in stock";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnRemoveRow);
      this.groupBox1.Controls.Add(this.txtCarToRemove);
      this.groupBox1.Location = new System.Drawing.Point(12, 230);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(291, 55);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Enter ID of Car to Delete";
      // 
      // btnRemoveRow
      // 
      this.btnRemoveRow.Location = new System.Drawing.Point(112, 18);
      this.btnRemoveRow.Name = "btnRemoveRow";
      this.btnRemoveRow.Size = new System.Drawing.Size(75, 23);
      this.btnRemoveRow.TabIndex = 1;
      this.btnRemoveRow.Text = "Delete!";
      this.btnRemoveRow.UseVisualStyleBackColor = true;
      this.btnRemoveRow.Click += new System.EventHandler(this.BtnRemoveRow_Click);
      // 
      // txtCarToRemove
      // 
      this.txtCarToRemove.Location = new System.Drawing.Point(6, 20);
      this.txtCarToRemove.Name = "txtCarToRemove";
      this.txtCarToRemove.Size = new System.Drawing.Size(100, 21);
      this.txtCarToRemove.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnDisplayMakes);
      this.groupBox2.Controls.Add(this.txtMakeToView);
      this.groupBox2.Location = new System.Drawing.Point(309, 230);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(263, 55);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Enter Make to View";
      // 
      // btnDisplayMakes
      // 
      this.btnDisplayMakes.Location = new System.Drawing.Point(112, 18);
      this.btnDisplayMakes.Name = "btnDisplayMakes";
      this.btnDisplayMakes.Size = new System.Drawing.Size(75, 23);
      this.btnDisplayMakes.TabIndex = 1;
      this.btnDisplayMakes.Text = "View!";
      this.btnDisplayMakes.UseVisualStyleBackColor = true;
      this.btnDisplayMakes.Click += new System.EventHandler(this.BtnDisplayMakes_Click);
      // 
      // txtMakeToView
      // 
      this.txtMakeToView.Location = new System.Drawing.Point(6, 20);
      this.txtMakeToView.Name = "txtMakeToView";
      this.txtMakeToView.Size = new System.Drawing.Size(100, 21);
      this.txtMakeToView.TabIndex = 0;
      // 
      // btnChangeMakes
      // 
      this.btnChangeMakes.Location = new System.Drawing.Point(315, 4);
      this.btnChangeMakes.Name = "btnChangeMakes";
      this.btnChangeMakes.Size = new System.Drawing.Size(257, 23);
      this.btnChangeMakes.TabIndex = 4;
      this.btnChangeMakes.Text = "Change All BMWs to Yogos";
      this.btnChangeMakes.UseVisualStyleBackColor = true;
      this.btnChangeMakes.Click += new System.EventHandler(this.BtnChangeMakes_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 288);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 12);
      this.label2.TabIndex = 6;
      this.label2.Text = "Only Yogos";
      // 
      // dataGridYugosView
      // 
      this.dataGridYugosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridYugosView.Location = new System.Drawing.Point(12, 303);
      this.dataGridYugosView.Name = "dataGridYugosView";
      this.dataGridYugosView.RowTemplate.Height = 23;
      this.dataGridYugosView.Size = new System.Drawing.Size(560, 169);
      this.dataGridYugosView.TabIndex = 5;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 484);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dataGridYugosView);
      this.Controls.Add(this.btnChangeMakes);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.carInventoryGridView);
      this.Name = "MainForm";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridYugosView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carInventoryGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.TextBox txtCarToRemove;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnDisplayMakes;
    private System.Windows.Forms.TextBox txtMakeToView;
    private System.Windows.Forms.Button btnChangeMakes;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dataGridYugosView;
  }
}

