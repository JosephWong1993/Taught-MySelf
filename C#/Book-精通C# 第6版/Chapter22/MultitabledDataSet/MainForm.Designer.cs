namespace MultitabledDataSet
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
      this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
      this.label3 = new System.Windows.Forms.Label();
      this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
      this.btnUpdateDatabase = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtCustID = new System.Windows.Forms.TextBox();
      this.btnGetOrderInfo = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridViewInventory
      // 
      this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewInventory.Location = new System.Drawing.Point(12, 24);
      this.dataGridViewInventory.Name = "dataGridViewInventory";
      this.dataGridViewInventory.RowTemplate.Height = 23;
      this.dataGridViewInventory.Size = new System.Drawing.Size(776, 100);
      this.dataGridViewInventory.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(107, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "Current Inventory";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 127);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(107, 12);
      this.label2.TabIndex = 3;
      this.label2.Text = "Current Customers";
      // 
      // dataGridViewCustomers
      // 
      this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 142);
      this.dataGridViewCustomers.Name = "dataGridViewCustomers";
      this.dataGridViewCustomers.RowTemplate.Height = 23;
      this.dataGridViewCustomers.Size = new System.Drawing.Size(776, 100);
      this.dataGridViewCustomers.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 245);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(89, 12);
      this.label3.TabIndex = 5;
      this.label3.Text = "Current Orders";
      // 
      // dataGridViewOrders
      // 
      this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewOrders.Location = new System.Drawing.Point(12, 260);
      this.dataGridViewOrders.Name = "dataGridViewOrders";
      this.dataGridViewOrders.RowTemplate.Height = 23;
      this.dataGridViewOrders.Size = new System.Drawing.Size(776, 100);
      this.dataGridViewOrders.TabIndex = 4;
      // 
      // btnUpdateDatabase
      // 
      this.btnUpdateDatabase.Location = new System.Drawing.Point(668, 366);
      this.btnUpdateDatabase.Name = "btnUpdateDatabase";
      this.btnUpdateDatabase.Size = new System.Drawing.Size(120, 23);
      this.btnUpdateDatabase.TabIndex = 6;
      this.btnUpdateDatabase.Text = "Update Database";
      this.btnUpdateDatabase.UseVisualStyleBackColor = true;
      this.btnUpdateDatabase.Click += new System.EventHandler(this.BtnUpdateDatabase_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnGetOrderInfo);
      this.groupBox1.Controls.Add(this.txtCustID);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Location = new System.Drawing.Point(12, 366);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(224, 75);
      this.groupBox1.TabIndex = 7;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Lookup Customer Order";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 17);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 12);
      this.label4.TabIndex = 4;
      this.label4.Text = "Customer ID:";
      // 
      // txtCustID
      // 
      this.txtCustID.Location = new System.Drawing.Point(89, 14);
      this.txtCustID.Name = "txtCustID";
      this.txtCustID.Size = new System.Drawing.Size(120, 21);
      this.txtCustID.TabIndex = 5;
      // 
      // btnGetOrderInfo
      // 
      this.btnGetOrderInfo.Location = new System.Drawing.Point(89, 41);
      this.btnGetOrderInfo.Name = "btnGetOrderInfo";
      this.btnGetOrderInfo.Size = new System.Drawing.Size(120, 23);
      this.btnGetOrderInfo.TabIndex = 7;
      this.btnGetOrderInfo.Text = "Get Order Details";
      this.btnGetOrderInfo.UseVisualStyleBackColor = true;
      this.btnGetOrderInfo.Click += new System.EventHandler(this.BtnGetOrderInfo_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnUpdateDatabase);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dataGridViewOrders);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dataGridViewCustomers);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridViewInventory);
      this.Name = "MainForm";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewInventory;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dataGridViewCustomers;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView dataGridViewOrders;
    private System.Windows.Forms.Button btnUpdateDatabase;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnGetOrderInfo;
    private System.Windows.Forms.TextBox txtCustID;
    private System.Windows.Forms.Label label4;
  }
}

