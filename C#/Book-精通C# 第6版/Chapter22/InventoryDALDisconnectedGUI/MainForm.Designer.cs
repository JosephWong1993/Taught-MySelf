namespace InventoryDALDisconnectedGUI
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
      this.btnUpdateInventory = new System.Windows.Forms.Button();
      this.inventoryGrid = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // btnUpdateInventory
      // 
      this.btnUpdateInventory.Location = new System.Drawing.Point(12, 12);
      this.btnUpdateInventory.Name = "btnUpdateInventory";
      this.btnUpdateInventory.Size = new System.Drawing.Size(75, 23);
      this.btnUpdateInventory.TabIndex = 0;
      this.btnUpdateInventory.Text = "修改";
      this.btnUpdateInventory.UseVisualStyleBackColor = true;
      this.btnUpdateInventory.Click += new System.EventHandler(this.BtnUpdateInventory_Click);
      // 
      // inventoryGrid
      // 
      this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.inventoryGrid.Location = new System.Drawing.Point(12, 41);
      this.inventoryGrid.Name = "inventoryGrid";
      this.inventoryGrid.RowTemplate.Height = 23;
      this.inventoryGrid.Size = new System.Drawing.Size(776, 397);
      this.inventoryGrid.TabIndex = 2;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.inventoryGrid);
      this.Controls.Add(this.btnUpdateInventory);
      this.Name = "MainForm";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnUpdateInventory;
    private System.Windows.Forms.DataGridView inventoryGrid;
  }
}

