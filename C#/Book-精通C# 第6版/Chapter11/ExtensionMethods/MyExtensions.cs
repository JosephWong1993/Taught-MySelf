using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        //  本方法允许任何对象显式它所处的程序集
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: => {1}", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        //  本方法允许任何整形返回倒置的副本,列如56将返回65
        public static int ReverseDigits(this int i)
        {
            //  把int翻译为string然后获取所有字符
            char[] digits = i.ToString().ToCharArray();

            //  现在反转数组中的项
            Array.Reverse(digits);

            //  放回string
            string newDigits = new string(digits);

            //  最后以int返回修改后的字符串
            return int.Parse(newDigits);
        }
    }
}
