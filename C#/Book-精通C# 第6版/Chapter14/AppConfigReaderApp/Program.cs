using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace AppConfigReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Reading <appSetting> Data *****");

            //  从*.config文件获取自定义数据
            AppSettingsReader ar = new AppSettingsReader();
            int numOfTimes = (int)ar.GetValue("RepeatCount", typeof(int));
            string textColor = (string)ar.GetValue("TextColor", typeof(string));

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), textColor);

            //  现在正确输出消息
            for (int i = 0; i < numOfTimes; i++)
            {
                Console.WriteLine("Howdy!");
            }
            Console.ReadLine();
        }
    }
}
