using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToXmlWinApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      //  在TextBox控件中显示当前库存的XML文档
      txtInventory.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
    }

    private void BtnAddNewItem_Click(object sender, EventArgs e)
    {
      //  为文档添加一个新项
      LinqToXmlObjectModel.InsertNewElement(txtMake.Text, txtColor.Text, txtPetName.Text);

      //  在TextBox控件中显示当前库存的XML文档
      txtInventory.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
    }

    private void BtnLookUpColors_Click(object sender, EventArgs e)
    {
      LinqToXmlObjectModel.LookUpColorsForMake(txtMakeToLookUp.Text);
    }
  }
}
