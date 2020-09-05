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

namespace RenderingWithShapes
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum SelectedShape
        {
            Circle, Rectangle, Line
        }

        private SelectedShape currentShape;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CanvasDrawingArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Shape shapeToRender = null;

            //  设置要绘制的形状
            switch (currentShape)
            {
                case SelectedShape.Circle:
                    shapeToRender = new Ellipse() { Fill = Brushes.Green, Height = 35, Width = 35 };
                    break;
                case SelectedShape.Rectangle:
                    shapeToRender = new Rectangle()
                    { Fill = Brushes.Red, Height = 35, Width = 35, RadiusX = 10, RadiusY = 10 };
                    break;
                case SelectedShape.Line:
                    shapeToRender = new Line()
                    {
                        Stroke = Brushes.Blue,
                        StrokeThickness = 10,
                        X1 = 0,
                        X2 = 50,
                        Y1 = 0,
                        Y2 = 50,
                        StrokeStartLineCap = PenLineCap.Triangle,
                        StrokeEndLineCap = PenLineCap.Round
                    };
                    break;
                default:
                    return;
            }

            //  设置形状在画布中距离顶部和左侧的相对位置
            Canvas.SetLeft(shapeToRender, e.GetPosition(CanvasDrawingArea).X);
            Canvas.SetTop(shapeToRender, e.GetPosition(CanvasDrawingArea).Y);
            //  绘制形状
            CanvasDrawingArea.Children.Add(shapeToRender);
        }

        private void circleOption_Click(object sender, RoutedEventArgs e)
        {
            currentShape = SelectedShape.Circle;
        }

        private void rectOption_Click(object sender, RoutedEventArgs e)
        {
            currentShape = SelectedShape.Rectangle;
        }

        private void lineOption_Click(object sender, RoutedEventArgs e)
        {
            currentShape = SelectedShape.Line;
        } 

        private void CanvasDrawingArea_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            //  首先，得到用户单击的X,Y位置
            Point pt = e.GetPosition((Canvas)sender);
            //  使用VisualTreeHelper的HitTest()方法来检查用户是否单击了画布中的某个对象
            HitTestResult result = VisualTreeHelper.HitTest(CanvasDrawingArea, pt);
            //  如果result不为null，说明鼠标确实单击了某个形状
            if (result != null)
            {
                //  获取被单击的那个形状，然后将其从画布中移除
                CanvasDrawingArea.Children.Remove(result.VisualHit as Shape);
            }
        }
    }
}
