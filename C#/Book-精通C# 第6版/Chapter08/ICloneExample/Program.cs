using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICloneExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Interfaces *****\n");

            //  这些类都支持ICloneable接口
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();

            //  因此,他们就可以传入接口ICloneable的方法
            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);

            Console.ReadLine();
        }

        private static void CloneMe(ICloneable c)
        {
            //克隆我们获得的并输出名字
            object theClone = c.Clone();
            Console.WriteLine("Your clone is a:{0}", theClone.GetType().Name);
        }
    }
}
