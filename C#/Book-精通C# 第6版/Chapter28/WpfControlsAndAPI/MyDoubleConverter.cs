using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfControlsAndAPI
{
    class MyDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //  将double转换为int
            double v = (double)value;
            return (int)v;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //  这里我们不用担心“双向”绑定，因此直接返回value
            return value;
        }
    }
}
