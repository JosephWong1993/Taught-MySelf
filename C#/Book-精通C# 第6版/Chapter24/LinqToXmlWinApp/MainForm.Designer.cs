namespace LinqToXmlWinApp
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
      this.txtInventory = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtMake = new System.Windows.Forms.TextBox();
      this.txtColor = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPetName = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnAddNewItem = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.txtMakeToLookUp = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.btnLookUpColors = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtInventory
      // 
      this.txtInventory.Location = new System.Drawing.Point(12, 24);
      this.txtInventory.Multiline = true;
      this.txtInventory.Name = "txtInventory";
      this.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtInventory.Size = new System.Drawing.Size(373, 202);
      this.txtInventory.TabIndex = 0;
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
      this.label2.Location = new System.Drawing.Point(453, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(113, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "Add Inventory Item";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(453, 45);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 12);
      this.label3.TabIndex = 3;
      this.label3.Text = "Make";
      // 
      // txtMake
      // 
      this.txtMake.Location = new System.Drawing.Point(520, 42);
      this.txtMake.Name = "txtMake";
      this.txtMake.Size = new System.Drawing.Size(247, 21);
      this.txtMake.TabIndex = 4;
      // 
      // txtColor
      // 
      this.txtColor.Location = new System.Drawing.Point(520, 69);
      this.txtColor.Name = "txtColor";
      this.txtColor.Size = new System.Drawing.Size(247, 21);
      this.txtColor.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(453, 72);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(35, 12);
      this.label4.TabIndex = 5;
      this.label4.Text = "Color";
      // 
      // txtPetName
      // 
      this.txtPetName.Location = new System.Drawing.Point(520, 96);
      this.txtPetName.Name = "txtPetName";
      this.txtPetName.Size = new System.Drawing.Size(247, 21);
      this.txtPetName.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(453, 99);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 12);
      this.label5.TabIndex = 7;
      this.label5.Text = "Pet Name";
      // 
      // btnAddNewItem
      // 
      this.btnAddNewItem.Location = new System.Drawing.Point(692, 123);
      this.btnAddNewItem.Name = "btnAddNewItem";
      this.btnAddNewItem.Size = new System.Drawing.Size(75, 23);
      this.btnAddNewItem.TabIndex = 9;
      this.btnAddNewItem.Text = "Add";
      this.btnAddNewItem.UseVisualStyleBackColor = true;
      this.btnAddNewItem.Click += new System.EventHandler(this.BtnAddNewItem_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(453, 161);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(143, 12);
      this.label6.TabIndex = 10;
      this.label6.Text = "Look up Colors for Make";
      // 
      // txtMakeToLookUp
      // 
      this.txtMakeToLookUp.Location = new System.Drawing.Point(554, 176);
      this.txtMakeToLookUp.Name = "txtMakeToLookUp";
      this.txtMakeToLookUp.Size = new System.Drawing.Size(213, 21);
      this.txtMakeToLookUp.TabIndex = 12;
      this.txtMakeToLookUp.Text = "BMW";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(453, 179);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(95, 12);
      this.label7.TabIndex = 11;
      this.label7.Text = "Make to Look up";
      // 
      // btnLookUpColors
      // 
      this.btnLookUpColors.Location = new System.Drawing.Point(667, 203);
      this.btnLookUpColors.Name = "btnLookUpColors";
      this.btnLookUpColors.Size = new System.Drawing.Size(100, 23);
      this.btnLookUpColors.TabIndex = 13;
      this.btnLookUpColors.Text = "Look Up Colors";
      this.btnLookUpColors.UseVisualStyleBackColor = true;
      this.btnLookUpColors.Click += new System.EventHandler(this.BtnLookUpColors_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 242);
      this.Controls.Add(this.btnLookUpColors);
      this.Controls.Add(this.txtMakeToLookUp);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.btnAddNewItem);
      this.Controls.Add(this.txtPetName);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtColor);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtMake);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtInventory);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtInventory;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMake;
    private System.Windows.Forms.TextBox txtColor;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPetName;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnAddNewItem;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtMakeToLookUp;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnLookUpColors;
  }
}

