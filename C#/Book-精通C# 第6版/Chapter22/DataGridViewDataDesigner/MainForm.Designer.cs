namespace DataGridViewDataDesigner
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
      this.components = new System.ComponentModel.Container();
      this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
      this.inventoryDataSet = new DataGridViewDataDesigner.InventoryDataSet();
      this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.inventoryTableAdapter = new DataGridViewDataDesigner.InventoryDataSetTableAdapters.InventoryTableAdapter();
      this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.petNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnUpdateInventory = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // inventoryDataGridView
      // 
      this.inventoryDataGridView.AutoGenerateColumns = false;
      this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.petNameDataGridViewTextBoxColumn});
      this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
      this.inventoryDataGridView.Location = new System.Drawing.Point(12, 12);
      this.inventoryDataGridView.Name = "inventoryDataGridView";
      this.inventoryDataGridView.RowTemplate.Height = 23;
      this.inventoryDataGridView.Size = new System.Drawing.Size(776, 397);
      this.inventoryDataGridView.TabIndex = 0;
      // 
      // inventoryDataSet
      // 
      this.inventoryDataSet.DataSetName = "InventoryDataSet";
      this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // inventoryBindingSource
      // 
      this.inventoryBindingSource.DataMember = "Inventory";
      this.inventoryBindingSource.DataSource = this.inventoryDataSet;
      // 
      // inventoryTableAdapter
      // 
      this.inventoryTableAdapter.ClearBeforeFill = true;
      // 
      // carIDDataGridViewTextBoxColumn
      // 
      this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
      this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
      this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
      // 
      // makeDataGridViewTextBoxColumn
      // 
      this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
      this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
      this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
      // 
      // colorDataGridViewTextBoxColumn
      // 
      this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
      this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
      this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
      // 
      // petNameDataGridViewTextBoxColumn
      // 
      this.petNameDataGridViewTextBoxColumn.DataPropertyName = "PetName";
      this.petNameDataGridViewTextBoxColumn.HeaderText = "PetName";
      this.petNameDataGridViewTextBoxColumn.Name = "petNameDataGridViewTextBoxColumn";
      // 
      // btnUpdateInventory
      // 
      this.btnUpdateInventory.Location = new System.Drawing.Point(661, 415);
      this.btnUpdateInventory.Name = "btnUpdateInventory";
      this.btnUpdateInventory.Size = new System.Drawing.Size(127, 23);
      this.btnUpdateInventory.TabIndex = 1;
      this.btnUpdateInventory.Text = "Update Inventory";
      this.btnUpdateInventory.UseVisualStyleBackColor = true;
      this.btnUpdateInventory.Click += new System.EventHandler(this.BtnUpdateInventory_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnUpdateInventory);
      this.Controls.Add(this.inventoryDataGridView);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView inventoryDataGridView;
    private InventoryDataSet inventoryDataSet;
    private System.Windows.Forms.BindingSource inventoryBindingSource;
    private InventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnUpdateInventory;
  }
}

