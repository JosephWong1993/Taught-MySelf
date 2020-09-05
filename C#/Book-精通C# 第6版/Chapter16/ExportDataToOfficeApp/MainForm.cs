using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ExportDataToOfficeApp
{
    public partial class MainForm : Form
    {
        List<Car> CarsInStock = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CarsInStock = new List<Car>()
            {
                new Car{Color="Green",Make="VW",PetName="Mary"},
                new Car{Color="Red",Make="Saab",PetName="Mel"},
                new Car{Color="Black",Make="Ford",PetName="Hank"},
                new Car{Color="Yellow",Make="BMW",PetName="Davie"}
            };
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            //  重新设置数据源
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = CarsInStock;
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            using (NewCarDialog d = new NewCarDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    //  向列表中添加一个新的Car
                    CarsInStock.Add(d.theCar);
                    UpdateGrid();
                }
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(CarsInStock);
        }

        static void ExportToExcel(List<Car> carsInStock)
        {
            //  加载Excel,创建一个新的空的工作簿
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            
            //  使Excel在计算机中可见
            excelApp.Visible = true;
            
            excelApp.Workbooks.Add();

            //  本示例需要一个工作表
            _Worksheet workSheet = excelApp.ActiveSheet;

            //  在单元格中创建列头
            workSheet.Cells[1, "A"] = "Make";
            workSheet.Cells[1, "B"] = "Color";
            workSheet.Cells[1, "C"] = "PetName";

            //  现在,将所有List<Car>中的数据映射到工作表中
            int row = 1;
            foreach (Car c in carsInStock)
            {
                row++;
                workSheet.Cells[row, "A"] = c.Make;
                workSheet.Cells[row, "B"] = c.Color;
                workSheet.Cells[row, "C"] = c.PetName;
            }

            //  美化表数据
            workSheet.Range["A1"].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);

            //  保存文件,退出Excel并将信息显示给客户
            workSheet.SaveAs(string.Format(@"{0}\Inventory.xlsx", Environment.CurrentDirectory));
            excelApp.Quit();
            MessageBox.Show("The Inventory.xlsx file has been saved to your app floder","Export complete");
        }
    }
}
