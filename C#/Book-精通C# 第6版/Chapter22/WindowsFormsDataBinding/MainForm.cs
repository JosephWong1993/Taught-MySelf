using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataBinding
{
  public partial class MainForm : Form
  {
    //  Car对象的集合
    List<Car> listCars = null;

    //  库存信息
    DataTable inventoryTable = new DataTable();

    //  DataTable的视图
    DataView yugosOnlyView;

    public MainForm()
    {
      InitializeComponent();

      //  填充一些汽车
      listCars = new List<Car>
            {
                new Car {ID=100,PetName="Chucky",Make="BMW",Color="Green" },
                new Car {ID=101,PetName="Thiny",Make="Yugo",Color="White" },
                new Car {ID=102,PetName="Ami",Make="Jeep",Color="Tan" },
                new Car {ID=103,PetName="Pain Inducer",Make="Garavan",Color="Pink" },
                new Car {ID=104,PetName="Fred",Make="BMW",Color="Green" },
                new Car {ID=105,PetName="Sidd",Make="BMW",Color="Black" },
                new Car {ID=106,PetName="Mel",Make="Firebird",Color="Red" },
                new Car {ID=107,PetName="Sarah",Make="Colt",Color="Black" },
            };

      //  建立一个数据表
      CreateDataTable();

      //  建立一个视图
      CreateDataView();
    }

    private void CreateDataView()
    {
      //  设置用来构建这个视图的表
      yugosOnlyView = new DataView(inventoryTable);

      //  用过滤器配置这个视图
      yugosOnlyView.RowFilter = "Make = 'Yugo'";

      //  绑定到新网格
      dataGridYugosView.DataSource = yugosOnlyView;
    }

    private void CreateDataTable()
    {
      //  创建表架构
      DataColumn carIDColumn = new DataColumn("ID", typeof(int));
      DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
      DataColumn carColorColumn = new DataColumn("Color", typeof(string));
      DataColumn carPetNameColumn = new DataColumn("PetName", typeof(string));
      carPetNameColumn.Caption = "Pet Name";
      inventoryTable.Columns.AddRange(new DataColumn[]
      {
        carIDColumn,carMakeColumn,carColorColumn,carPetNameColumn
      });

      //  秩代数组列表List<T>来创建行
      foreach (Car c in listCars)
      {
        DataRow newRow = inventoryTable.NewRow();
        newRow["ID"] = c.ID;
        newRow["Make"] = c.Make;
        newRow["Color"] = c.Color;
        newRow["PetName"] = c.PetName;
        inventoryTable.Rows.Add(newRow);
      }

      //  把DataTable绑定到carInventoryGridView
      carInventoryGridView.DataSource = inventoryTable;
    }

    //  从DataRowCollection删除这行
    private void BtnRemoveRow_Click(object sender, EventArgs e)
    {
      try
      {
        //  找到要删除的行
        DataRow[] rowToDelete = inventoryTable.Select(
          string.Format("ID={0}", int.Parse(txtCarToRemove.Text))
        );

        //  删除它
        rowToDelete[0].Delete();
        inventoryTable.AcceptChanges();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);

      }
    }

    private void BtnDisplayMakes_Click(object sender, EventArgs e)
    {
      //  根据用户输入的内容构建过滤器
      string filterStr = string.Format("Make= '{0}'", txtMakeToView.Text);

      //  查找符合条件的所有记录
      DataRow[] makes = inventoryTable.Select(filterStr);
      //  按照PetName排序
      makes = inventoryTable.Select(filterStr, "PetName");
      //  以倒序返回结果
      makes = inventoryTable.Select(filterStr, "PetName DESC");

      if (makes.Length == 0)
      {
        MessageBox.Show("Sorry, no cars...", "Selection error!");
      }
      else
      {
        string strMake = "";
        for (int i = 0; i < makes.Length; i++)
        {
          //  从当前行开始,获取PetName的值
          strMake += makes[i]["PetName"] + "\n";
        }

        //  显示消息框中所有符合条件的记录
        MessageBox.Show(strMake, string.Format("We have {0}s named:", txtMakeToView.Text));
      }

      ShowCarsWithIdGreaterThanFive();
    }

    private void ShowCarsWithIdGreaterThanFive()
    {
      //  现在显示所有ID大于5的汽车名字
      DataRow[] properIDs;
      string newFilterStr = "ID > 5";
      properIDs = inventoryTable.Select(newFilterStr);
      string strIDs = null;
      for (int i = 0; i < properIDs.Length; i++)
      {
        DataRow temp = properIDs[i];
        strIDs += temp["PetName"]
          + " is ID " + temp["ID"] + "\n";
      }
      MessageBox.Show(strIDs, "Pet names of cars where ID > 5");
    }

    //  用过滤器找到想编辑的行
    private void BtnChangeMakes_Click(object sender, EventArgs e)
    {
      //  确认用户是否改变主意
      if (DialogResult.Yes == MessageBox.Show("Are you sure?? BMWs are much nicer than Yogos!",
        "Please Confirm!", MessageBoxButtons.YesNo))
      {
        //  建立一个过滤器
        string filterStr = "Make= 'BMW'";
        string strMake = string.Empty;

        //  找到所有匹配过滤器的行
        DataRow[] makes = inventoryTable.Select(filterStr);

        //  把所有的"Beemers"修改成"Yogos"
        for (int i = 0; i < makes.Length; i++)
        {
          makes[i]["Make"] = "Yugo";
        }
      }
    }
  }
}
