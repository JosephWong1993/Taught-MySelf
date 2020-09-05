using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Ink;
using System.Windows.Annotations;
using System.Windows.Annotations.Storage;
using System.Windows.Markup;
using AutoLotDAL;

namespace WpfControlsAndAPI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 默认模式为Ink
            this.myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            this.inkRadio.IsChecked = true;
            this.comboColors.SelectedIndex = 0;

            this.PopulateDocument();
            this.EnableAnnotations();

            btnSaveDoc.Click += (o, s) =>
            {
                using (FileStream fStream = File.Open("documentData.xmal", FileMode.Create))
                {
                    XamlWriter.Save(this.myDocumentReader.Document, fStream);
                }
            };

            btnLoadDoc.Click += (o, s) =>
            {
                using (FileStream fStream = File.Open("documentData.xmal", FileMode.Open))
                {
                    try
                    {
                        FlowDocument doc = XamlReader.Load(fStream) as FlowDocument;
                        this.myDocumentReader.Document = doc;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Loading Doc!");
                    }
                }
            };

            this.SetBindings();
            this.CondigureGrid();
        }

        private void RadioButtonClicked(object sender, System.Windows.RoutedEventArgs e)
        {
            //  根据传入的按钮，设置InkCanvas的操作模式
            switch ((sender as RadioButton).Content.ToString())
            {
                //  这些字符串必须与各个RadioButton的Content值相同
                case "Ink Mode!":
                    this.myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "Erase Mode!":
                    this.myInkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
                case "Select Mode!":
                    this.myInkCanvas.EditingMode = InkCanvasEditingMode.Select;
                    break;
            }
        }

        private void ColorChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //  获取组合框中选中的值
            string colorToUse = (this.comboColors.SelectedItem as StackPanel).Tag.ToString();

            //  更改笔画呈现的颜色
            this.myInkCanvas.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(colorToUse);
        }

        private void SaveData(object sender, RoutedEventArgs e)
        {
            //  在本地文件中保存InkCanvas的所有数据
            using (FileStream fs = new FileStream("StrokeData.bin", FileMode.Create))
            {
                this.myInkCanvas.Strokes.Save(fs);
                fs.Close();
            }
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            //  从文件中获取数据，填充StrokeCollection
            using (FileStream fs = new FileStream("StrokeData.bin", FileMode.Open, FileAccess.Read))
            {
                StrokeCollection strokes = new StrokeCollection(fs);
                this.myInkCanvas.Strokes = strokes;
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            //  清除所有笔画
            this.myInkCanvas.Strokes.Clear();
        }

        private void PopulateDocument()
        {
            //  向List项中添加一些数据
            this.listOfFunFacts.FontSize = 14;
            this.listOfFunFacts.MarkerStyle = TextMarkerStyle.Circle;
            this.listOfFunFacts.ListItems.Add(new ListItem(
                new Paragraph(new Run("Fixed documents are for WYSIWYG print ready docs!"))));
            this.listOfFunFacts.ListItems.Add(new ListItem(
                new Paragraph(new Run("The API supports tables and embedded figures!"))));
            this.listOfFunFacts.ListItems.Add(new ListItem(
                new Paragraph(new Run("Flow documents are ready only!"))));
            this.listOfFunFacts.ListItems.Add(new ListItem(
                new Paragraph(new Run("BlockUIContainer allows you to embed WPF controls in the document!"))));

            //  向Paragraph中添加一些数据
            //  句子的第一部分
            Run prefix = new Run("This paragraph was generated ");

            //  段落的中间部分
            Bold b = new Bold();
            Run infix = new Run("dynamically");
            infix.Foreground = Brushes.Red;
            infix.FontSize = 30;
            b.Inlines.Add(infix);

            //  段落的最后部分
            Run suffix = new Run(" at runtime!");

            //  向内联元素的集合中添加段落的各个部分
            this.paraBodyText.Inlines.Add(prefix);
            this.paraBodyText.Inlines.Add(infix);
            this.paraBodyText.Inlines.Add(suffix);
        }

        private void EnableAnnotations()
        {
            //  创建用于FlowDocumentReader的AnnotationService对象
            AnnotationService anoService = new AnnotationService(myDocumentReader);

            //  创建用于存放批注的MemoryStream
            MemoryStream anoStream = new MemoryStream();

            //  根据MemoryStream创建基于XML的存储
            //  可以使用这个对象以编程的方式添加、删除或查找批注
            AnnotationStore store = new XmlStreamStore(anoStream);

            //  启用批注服务
            anoService.Enable(store);
        }

        private void SetBindings()
        {
            //  创建Binding对象
            Binding b = new Binding();

            //  注册转换器、源和路径
            b.Converter = new MyDoubleConverter();
            b.Source = this.mySB;
            b.Path = new PropertyPath("Value");

            //  调用Label的SetBinding()方法
            this.lablelSBThumb.SetBinding(Label.ContentProperty, b);
        }

        private void CondigureGrid()
        {
            using (AutoLotEntities context = new AutoLotEntities())
            {
                //  构建从Inventory表中获取数据的LINQ查询
                var dataToShow = from c in context.Inventories
                                 select new { c.CarID, c.Make, c.Color, c.PetName };
                this.gridInventory.ItemsSource = dataToShow;
            }
        }
    }
}
