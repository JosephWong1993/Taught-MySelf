namespace ExportDataToOfficeApp
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCars
            // 
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(12, 80);
            this.dataGridCars.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.RowTemplate.Height = 23;
            this.dataGridCars.Size = new System.Drawing.Size(760, 450);
            this.dataGridCars.TabIndex = 0;
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Location = new System.Drawing.Point(81, 554);
            this.btnAddNewCar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(250, 23);
            this.btnAddNewCar.TabIndex = 1;
            this.btnAddNewCar.Text = "Add New Emtry to Inventory";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(455, 554);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(250, 23);
            this.btnExportToExcel.TabIndex = 2;
            this.btnExportToExcel.Text = "Export Current Inventory to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Inventory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.dataGridCars);
            this.Name = "MainForm";
            this.Text = "The Office COM Interop App!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label label1;
    }
}

